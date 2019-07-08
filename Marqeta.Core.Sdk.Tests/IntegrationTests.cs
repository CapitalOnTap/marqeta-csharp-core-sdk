using System.Linq;
using AutoFixture;
using Marqeta.Core.Abstractions;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public class CardProductTests : BaseTests
    {
        public CardProductTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        private const string DefaultCardProductToken = "dev_virtual_card";
        private const string DefaultFundingProgramSourceToken = "7dc603f7-bfed-4f28-801c-6af2de4b4661";
        private const string DefaultProgramTransferTypeToken = "default_funding_source_program_trans";

        private const string DefaultCardToken = "f642cb44-29d0-4b05-a234-b02451b018e3";
        private const string DefaultUserToken = "5db91389-3765-4e74-8bb6-43ccbb04d3d1";

        [Fact]
        public void Ping()
        {
            var client = GetMarqetaClient();
            var response = client.PingGetAsync().Result;
            Assert.NotNull(response);
            Assert.True(response.Success);
        }

        [Fact]
        public void CardProducts()
        {
            var client = GetMarqetaClient();
            var response = client.CardproductsGetAsync().Result;
        }

        [Fact]
        public void Users()
        {
            var client = GetMarqetaClient();
            var response = client.UsersGetAsync().Result;
        }

        [Fact]
        public void Test()
        {
            var client = GetMarqetaClient();

            var users = client.UsersGetAsync().Result.Data;
            Card_response cardResponse = null;

            foreach (var user in users)
            {
                var cards = client.CardsUserAsync(user.Token).Result.Data;
                cardResponse = cards.FirstOrDefault(c => c.State == Card_responseState.ACTIVE);
                if (cardResponse != null) {  break; }
            }

            var cardRequest = new Card_request
            {
                User_token = cardResponse.User_token,
                Card_product_token = cardResponse.Card_product_token,
                Reissue_pan_from_card_token = cardResponse.Token,
            };
            var card1 = client.CardsPostAsync(cardRequest).Result;
        }

        [Fact]
        public void UtiliseFunds()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            const double amount = 10;

            // Ensure user has funds
            var balances0 = client.BalancesAsync(DefaultUserToken).Result;
            Assert.True(balances0.Gpa.Ledger_balance >= amount);
            Assert.True(balances0.Gpa.Available_balance >= amount);

            // Transact
            var authRequest = new Auth_request_model
            {
                Amount = amount,
                Mid = fixture.Create<string>(),
                Card_token = DefaultCardToken,
            };
            var simulateAuthorizationResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateAuthorizationResponse);

            var balances1 = client.BalancesAsync(DefaultUserToken).Result;
            Assert.Equal(balances0.Gpa.Ledger_balance, balances1.Gpa.Ledger_balance);
            Assert.Equal(balances0.Gpa.Available_balance - amount, balances1.Gpa.Available_balance);

            var clearingModel = new ClearingModel
            {
                Amount = amount,
                Original_transaction_token = simulateAuthorizationResponse.Transaction.Token
            };
            var simulateClearingResponseModel = client.SimulateClearingAsync(clearingModel).Result;
            Assert.NotNull(simulateClearingResponseModel);

            var balances2 = client.BalancesAsync(DefaultUserToken).Result;
            Assert.Equal(balances1.Gpa.Ledger_balance - amount, balances2.Gpa.Ledger_balance);
            Assert.Equal(balances1.Gpa.Available_balance, balances2.Gpa.Available_balance);
        }

        [Fact]
        public void UnloadFundsPostTransaction()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = DefaultCardProductToken,
            };
            var cardResponse = client.CardsPostAsync(cardRequest).Result;
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = client.CardtransitionsPostAsync(cardTransitionRequest).Result;
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            const double gpaAmount = 1000;
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = gpaAmount,
                Currency_code = "GBP",
                Funding_source_token = DefaultFundingProgramSourceToken
            };
            var gpaResponse = client.GpaordersPostAsync(gpaRequest).Result;
            Assert.NotNull(gpaResponse);

            // Ensure user has funds
            var balances0 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount, balances0.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount, balances0.Gpa.Available_balance);

            // Transact
            const double transactionAmount = 500;
            var authRequest = new Auth_request_model
            {
                Amount = transactionAmount,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateAuthorizationResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateAuthorizationResponse);

            // Clear transaction
            var clearingModel = new ClearingModel
            {
                Amount = transactionAmount,
                Original_transaction_token = simulateAuthorizationResponse.Transaction.Token
            };
            var simulateClearingResponseModel = client.SimulateClearingAsync(clearingModel).Result;
            Assert.NotNull(simulateClearingResponseModel);

            var balances1 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Available_balance);

            // Unload
            var unloadAmount = balances1.Gpa.Ledger_balance;
            var unloadRequest = new Program_transfer
            {
                Amount = unloadAmount,
                Type_token = DefaultProgramTransferTypeToken,
                User_token = cardHolderResponse.Token,
                Tags = "unload",
                Memo = "unload"
            };
            var response = client.ProgramtransfersPostAsync(unloadRequest).Result;
            Assert.NotNull(response);

            var balances2 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(0, balances2.Gpa.Ledger_balance);
            Assert.Equal(0, balances2.Gpa.Available_balance);
        }

        [Fact]
        public void UnloadFundsPostTransaction_Complex()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = DefaultCardProductToken,
            };
            var cardResponse = client.CardsPostAsync(cardRequest).Result;
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = client.CardtransitionsPostAsync(cardTransitionRequest).Result;
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            const double gpaAmount = 1000;
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = gpaAmount,
                Currency_code = "GBP",
                Funding_source_token = DefaultFundingProgramSourceToken
            };
            var gpaResponse = client.GpaordersPostAsync(gpaRequest).Result;
            Assert.NotNull(gpaResponse);

            // Ensure user has funds
            var balances0 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount, balances0.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount, balances0.Gpa.Available_balance);

            // Transact
            const double transactionAmount = 500;
            var authRequest = new Auth_request_model
            {
                Amount = transactionAmount,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateAuthorizationResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateAuthorizationResponse);

            // Clear transaction
            var clearingModel = new ClearingModel
            {
                Amount = transactionAmount,
                Original_transaction_token = simulateAuthorizationResponse.Transaction.Token
            };
            var simulateClearingResponseModel = client.SimulateClearingAsync(clearingModel).Result;
            Assert.NotNull(simulateClearingResponseModel);

            var balances1 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Available_balance);

            // Fund user account - Simulate customer repayment
            var gpaRequest1 = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = transactionAmount,
                Currency_code = "GBP",
                Funding_source_token = DefaultFundingProgramSourceToken
            };
            var gpaResponse1 = client.GpaordersPostAsync(gpaRequest1).Result;
            Assert.NotNull(gpaResponse);

            // Ensure user has funds
            var balances2 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount, balances2.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount, balances2.Gpa.Available_balance);

            // Unload
            var unloadAmount = balances2.Gpa.Ledger_balance;
            var unloadRequest = new Program_transfer
            {
                Amount = unloadAmount,
                Type_token = DefaultProgramTransferTypeToken,
                User_token = cardHolderResponse.Token,
                Tags = "unload",
                Memo = "unload"
            };
            var response = client.ProgramtransfersPostAsync(unloadRequest).Result;
            Assert.NotNull(response);

            var balances3 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(0, balances3.Gpa.Ledger_balance);
            Assert.Equal(0, balances3.Gpa.Available_balance);
        }

        [Fact]
        public void UnloadFundsPostTransaction_AuthNotCleared()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = DefaultCardProductToken,
            };
            var cardResponse = client.CardsPostAsync(cardRequest).Result;
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = client.CardtransitionsPostAsync(cardTransitionRequest).Result;
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            const double gpaAmount = 1000;
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = gpaAmount,
                Currency_code = "GBP",
                Funding_source_token = DefaultFundingProgramSourceToken
            };
            var gpaResponse = client.GpaordersPostAsync(gpaRequest).Result;
            Assert.NotNull(gpaResponse);

            // Ensure user has funds
            var balances0 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount, balances0.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount, balances0.Gpa.Available_balance);

            // Transact
            const double transactionAmount = 500;
            var authRequest = new Auth_request_model
            {
                Amount = transactionAmount,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateAuthorizationResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateAuthorizationResponse);

            // NB: The transaction has not cleared
            var balances1 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount, balances1.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Available_balance);

            // Unload
            var unloadAmount = balances1.Gpa.Available_balance;
            var unloadRequest = new Program_transfer
            {
                Amount = unloadAmount,
                Type_token = DefaultProgramTransferTypeToken,
                User_token = cardHolderResponse.Token,
                Tags = "unload",
                Memo = "unload"
            };
            var response = client.ProgramtransfersPostAsync(unloadRequest).Result;
            Assert.NotNull(response);

            var balances2 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount - transactionAmount, balances2.Gpa.Ledger_balance);
            Assert.Equal(0, balances2.Gpa.Available_balance);
        }

        [Fact]
        public void UnloadFundsPostTransaction_AuthNotCleared_ThenRefunded()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = DefaultCardProductToken,
            };
            var cardResponse = client.CardsPostAsync(cardRequest).Result;
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = client.CardtransitionsPostAsync(cardTransitionRequest).Result;
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            const double gpaAmount = 1000;
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = gpaAmount,
                Currency_code = "GBP",
                Funding_source_token = DefaultFundingProgramSourceToken
            };
            var gpaResponse = client.GpaordersPostAsync(gpaRequest).Result;
            Assert.NotNull(gpaResponse);

            // Ensure user has funds
            var balances0 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount, balances0.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount, balances0.Gpa.Available_balance);

            // Transact
            const double transactionAmount = 500;
            var authRequest = new Auth_request_model
            {
                Amount = transactionAmount,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateAuthorizationResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateAuthorizationResponse);

            // NB: The transaction has not cleared
            var balances1 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount, balances1.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Available_balance);

            // Unload
            var unloadAmount = balances1.Gpa.Available_balance;
            var unloadRequest = new Program_transfer
            {
                Amount = unloadAmount,
                Type_token = DefaultProgramTransferTypeToken,
                User_token = cardHolderResponse.Token,
                Tags = "unload",
                Memo = "unload"
            };
            var response = client.ProgramtransfersPostAsync(unloadRequest).Result;
            Assert.NotNull(response);

            var balances2 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(gpaAmount - transactionAmount, balances2.Gpa.Ledger_balance);
            Assert.Equal(0, balances2.Gpa.Available_balance);

            // Simulate reversal
            var reversalModel = new ReversalModel
            {
                Amount = transactionAmount,
                Original_transaction_token = simulateAuthorizationResponse.Transaction.Token
            };
            var simulateClearingResponseModel = client.SimulateReversalAsync(reversalModel).Result;
            Assert.NotNull(simulateClearingResponseModel);

            var balances3 = client.BalancesAsync(cardHolderResponse.Token).Result;
            Assert.Equal(transactionAmount, balances3.Gpa.Ledger_balance);
            Assert.Equal(transactionAmount, balances3.Gpa.Available_balance);
        }

        [Fact]
        public void QuickStart()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Get the latest card product
            var cardProductToken = client.CardproductsGetAsync().Result.Data
                .OrderByDescending(x => x.Last_modified_time).First().Token;
            Assert.NotEmpty(cardProductToken);

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = client.FundingsourcesProgramPostAsync(programFundingSourceRequest).Result;
            Assert.NotNull(programFundingSourceResponse);

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = cardProductToken,
            };
            var cardResponse = client.CardsPostAsync(cardRequest).Result;
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = client.CardtransitionsPostAsync(cardTransitionRequest).Result;
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = 1000,
                //Currency_code = "GBP",
                Currency_code = "USD",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = client.GpaordersPostAsync(gpaRequest).Result;
            Assert.NotNull(gpaResponse);

            // Transact
            var authRequest = new Auth_request_model
            {
                Amount = 10,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateResponse);
        }

        [Fact]
        public void QuickStartWithWebhook()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Get the latest card product
            var cardProductToken = client.CardproductsGetAsync().Result.Data
                .OrderByDescending(x => x.Last_modified_time).First().Token;
            Assert.NotEmpty(cardProductToken);

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = client.FundingsourcesProgramPostAsync(programFundingSourceRequest).Result;
            Assert.NotNull(programFundingSourceResponse);

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = cardProductToken,
            };
            var cardResponse = client.CardsPostAsync(cardRequest).Result;
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = client.CardtransitionsPostAsync(cardTransitionRequest).Result;
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = 1000,
                //Currency_code = "GBP",
                Currency_code = "USD",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = client.GpaordersPostAsync(gpaRequest).Result;
            Assert.NotNull(gpaResponse);

            // Transact
            var authRequest = new Auth_request_model
            {
                Amount = 10,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
                Webhook = new Webhook
                {
                    Endpoint = "https://quick-start-guide.free.beeceptor.com",
                    Username = fixture.Create<string>(),
                    Password = fixture.Create<string>()
                }
            };
            var simulateResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateResponse);
        }

        [Fact]
        public void Complete()
        {
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            var cardProductToken = client.CardproductsGetAsync().Result.Data
                .OrderByDescending(x => x.Last_modified_time).First().Token;

            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = client.FundingsourcesProgramPostAsync(programFundingSourceRequest).Result;

            //var cardHolderModel = fixture.Build<Card_holder_model>()
            //    .Without(chm => chm.Gender)
            //    .Create();
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;

            //var cardRequest = fixture.Build<Card_request>()
            //    .With(cr => cr.User_token, cardHolderResponse.Token)
            //    .With(cr => cr.Card_product_token, cardProductToken)
            //    .Create();
            var cardRequest1 = new Card_request
                {
                    User_token = cardHolderResponse.Token,
                    Card_product_token = cardProductToken,
                };
            var card1 = client.CardsPostAsync(cardRequest1).Result;

            //var cardRequest2 = fixture.Build<Card_request>()
            //    .With(cr => cr.User_token, cardHolderResponse.Token)
            //    .With(cr => cr.Card_product_token, cardProductToken)
            //    .With(cr => cr.Reissue_pan_from_card_token, card1.Token)
            //    .Create();
            var cardRequest2 = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = cardProductToken,
                Reissue_pan_from_card_token = card1.Token,
            };
            var card2 = client.CardsPostAsync(cardRequest2).Result;
        }
    }
}