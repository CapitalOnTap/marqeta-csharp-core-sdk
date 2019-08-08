using System;
using System.Linq;
using AutoFixture;
using Marqeta.Core.Abstractions;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public class VelocityControlTests : BaseTests
    {
        public VelocityControlTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        [Fact]
        public async void Test1()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            //// Get the latest card product
            //var cardProductToken = (await client.CardproductsGetAsync())
            //    .Data.OrderByDescending(x => x.Last_modified_time).First().Token;
            //Assert.NotEmpty(cardProductToken);
            var cardProductRequest = new Card_product_request
            {
                Start_date = DateTimeOffset.Now.Date.AddDays(-1),
                Name = fixture.Create<string>(),
                Config = new Card_product_config
                {
                    Fulfillment = new Card_product_fulfillment { Payment_instrument = Card_product_fulfillmentPayment_instrument.VIRTUAL_PAN },
                    Poi = new Poi { Ecommerce = true },
                    Card_life_cycle = new Card_life_cycle { Activate_upon_issue = true },
                }
            };
            var cardProductResponse = await client.CardproductsPostAsync(cardProductRequest);

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = await client.FundingsourcesProgramPostAsync(programFundingSourceRequest);
            Assert.NotNull(programFundingSourceResponse);

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = await client.UsersPostAsync(cardHolderModel);
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = cardProductResponse.Token,
            };
            var cardResponse = await client.CardsPostAsync(cardRequest);
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = await client.CardtransitionsPostAsync(cardTransitionRequest);
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = 1000,
                Currency_code = "USD",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);

            // Add velocity control
            var velocityControlRequest = new Velocity_control_request
            {
                // Token - Perhaps set this?
                Amount_limit = 10,
                // Pending question with Marqeta
                Velocity_window = Velocity_control_requestVelocity_window.LIFETIME,
                //Velocity_window = Velocity_control_requestVelocity_window.MONTH,
                Currency_code = "USD",
                Association = new Spend_control_association { User_token = cardHolderResponse.Token },
            };
            var vcResponse = await client.VelocitycontrolsPostAsync(velocityControlRequest);

            var a = await client.BalancesAsync(cardHolderResponse.Token);

            // Transact 1
            var authRequest = new Auth_request_model
            {
                Amount = 10,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateResponse = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateResponse);

            var clearingModel = new ClearingModel
            {
                Amount = 10,
                Original_transaction_token = simulateResponse.Transaction.Token
            };
            var simulateClearingResponseModel = await client.SimulateClearingAsync(clearingModel);
            Assert.NotNull(simulateClearingResponseModel);

            var balance = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(990, balance.Gpa.Available_balance);

            // Transact 2
            var simulateResponse2 = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateResponse2);
        }

        private const string DefaultCardProductToken = "dev_virtual_card";
        private const string DefaultFundingProgramSourceToken = "7dc603f7-bfed-4f28-801c-6af2de4b4661";
        private const string DefaultProgramTransferTypeToken = "default_funding_source_program_trans";
        private const string DefaultCardToken = "f642cb44-29d0-4b05-a234-b02451b018e3";
        private const string DefaultUserToken = "5db91389-3765-4e74-8bb6-43ccbb04d3d1";

        [Fact]
        public async void UtiliseFunds()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            const double amount = 10;

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = await client.UsersPostAsync(cardHolderModel);
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = DefaultCardProductToken,
            };
            var cardResponse = await client.CardsPostAsync(cardRequest);
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = await client.CardtransitionsPostAsync(cardTransitionRequest);
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
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);

            // Ensure user has funds
            var balances0 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(gpaAmount, balances0.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount, balances0.Gpa.Available_balance);

            // Add velocity control
            var velocityControlRequest = new Velocity_control_request
            {
                // Token - Perhaps set this?
                Amount_limit = 500,
                // Pending question with Marqeta
                Velocity_window = Velocity_control_requestVelocity_window.LIFETIME,
                //Velocity_window = Velocity_control_requestVelocity_window.MONTH,
                Currency_code = "USD",
                Association = new Spend_control_association { User_token = cardHolderResponse.Token },
            };
            var vcResponse = await client.VelocitycontrolsPostAsync(velocityControlRequest);

            // Transact
            const double transactionAmount = 500;
            var authRequest = new Auth_request_model
            {
                Amount = transactionAmount,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateAuthorizationResponse = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateAuthorizationResponse);
            Assert.Equal(Transaction_modelState.PENDING, simulateAuthorizationResponse.Transaction.State);

            // Clear transaction
            var clearingModel = new ClearingModel
            {
                Amount = transactionAmount,
                Original_transaction_token = simulateAuthorizationResponse.Transaction.Token
            };
            var simulateClearingResponseModel = await client.SimulateClearingAsync(clearingModel);
            Assert.NotNull(simulateClearingResponseModel);

            var balances1 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Available_balance);

            // Transact 2
            var simulateAuthorizationResponse2 = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateAuthorizationResponse2);
            Assert.Equal(Transaction_modelState.DECLINED, simulateAuthorizationResponse2.Transaction.State);

            var balances2 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(balances1.Gpa.Ledger_balance, balances2.Gpa.Ledger_balance);
            Assert.Equal(balances1.Gpa.Available_balance, balances2.Gpa.Available_balance);
        }

        [Fact]
        public async void UtiliseFunds2()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            const double amount = 10;

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = await client.UsersPostAsync(cardHolderModel);
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = DefaultCardProductToken,
            };
            var cardResponse = await client.CardsPostAsync(cardRequest);
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = await client.CardtransitionsPostAsync(cardTransitionRequest);
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
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);

            // Ensure user has funds
            var balances0 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(gpaAmount, balances0.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount, balances0.Gpa.Available_balance);

            // Add velocity control
            var velocityControlRequest = new Velocity_control_request
            {
                // Token - Perhaps set this?
                Amount_limit = 500,
                // Pending question with Marqeta
                Velocity_window = Velocity_control_requestVelocity_window.LIFETIME,
                //Velocity_window = Velocity_control_requestVelocity_window.MONTH,
                Currency_code = "USD",
                Association = new Spend_control_association { User_token = cardHolderResponse.Token },
            };
            var vcResponse = await client.VelocitycontrolsPostAsync(velocityControlRequest);

            // Transact
            const double transactionAmount = 500;
            var authRequest = new Auth_request_model
            {
                Amount = transactionAmount,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateAuthorizationResponse = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateAuthorizationResponse);
            Assert.Equal(Transaction_modelState.PENDING, simulateAuthorizationResponse.Transaction.State);

            // Clear transaction
            var clearingModel = new ClearingModel
            {
                Amount = transactionAmount,
                Original_transaction_token = simulateAuthorizationResponse.Transaction.Token
            };
            var simulateClearingResponseModel = await client.SimulateClearingAsync(clearingModel);
            Assert.NotNull(simulateClearingResponseModel);

            var balances1 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Ledger_balance);
            Assert.Equal(gpaAmount - transactionAmount, balances1.Gpa.Available_balance);

            // Transact 2
            var simulateAuthorizationResponse2 = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateAuthorizationResponse2);
            Assert.Equal(Transaction_modelState.DECLINED, simulateAuthorizationResponse2.Transaction.State);

            // Check balance
            var balances2 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(balances1.Gpa.Ledger_balance, balances2.Gpa.Ledger_balance);
            Assert.Equal(balances1.Gpa.Available_balance, balances2.Gpa.Available_balance);

            // Reset
            var velocityControl = (await client.VelocitycontrolsGetAsync(user: cardHolderResponse.Token)).Data.First();
            Assert.NotNull(velocityControl);
            var velocityControlUpdateRequest = new Velocity_control_update_request { Velocity_window = Velocity_control_update_requestVelocity_window.DAY };
            var velocityControlResponse = await client.VelocitycontrolsPutAsync(velocityControl.Token, velocityControlUpdateRequest);
            Assert.NotNull(velocityControlResponse);
            velocityControlUpdateRequest.Velocity_window = Velocity_control_update_requestVelocity_window.LIFETIME;
            velocityControlResponse = await client.VelocitycontrolsPutAsync(velocityControl.Token, velocityControlUpdateRequest);
            Assert.NotNull(velocityControlResponse);

            // Transact 3
            var simulateAuthorizationResponse3 = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateAuthorizationResponse3);
            Assert.Equal(Transaction_modelState.PENDING, simulateAuthorizationResponse3.Transaction.State);
        }

    }
}