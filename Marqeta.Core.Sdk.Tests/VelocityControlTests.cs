using AutoFixture;
using Marqeta.Core.Abstractions;
using Marqeta.Core.Sdk.Tests.Factories;
using Marqeta.Core.Sdk.Tests.Helpers;
using Xunit;

namespace Marqeta.Core.Sdk.Tests
{
    public class VelocityControlTests : BaseTests
    {
        [Fact]
        public async void Ensure_velocity_control_lifetime_is_honoured()
        {
            // Get client / fixture
            var client = ClientFactory.GetMarqetaClient();
            var fixture = new Fixture();

            //
            // NB: Responses from other test classes have already had assertions run against them
            //
            // Get card product
            var cardProductResponse = await CardProductHelper.CreateCardProduct();

            // Create a program funding source
            var programFundingSourceResponse = await ProgramFundingHelper.CreateProgramFundingSource();

            // Create user account
            var cardHolderResponse = await UserHelper.CreateUser();

            // Create / activate card
            var cardResponse = await CardTests.CreateCard(cardHolderResponse.Token, cardProductResponse.Token);
            //await CardTests.ActivateCard(cardResponse.Token);

            // Fund user account
            const double fundingAmount = 1000;
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = fundingAmount,
                Currency_code = "USD",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);
            var balances1 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(fundingAmount, balances1.Gpa.Available_balance);

            // Add velocity control
            const double velocityControlAmount = 10;
            var velocityControlRequest = new Velocity_control_request
            {
                Amount_limit = velocityControlAmount,
                Velocity_window = Velocity_control_requestVelocity_window.LIFETIME,
                Currency_code = "USD",
                Association = new Spend_control_association { User_token = cardHolderResponse.Token },
            };
            var vcResponse = await client.VelocitycontrolsPostAsync(velocityControlRequest);
            Assert.NotNull(vcResponse);

            // Transact 1 - This should succeed
            var authRequest1 = new Auth_request_model
            {
                Amount = velocityControlAmount,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateResponse1 = await client.SimulateAuthorizationAsync(authRequest1);
            Assert.NotNull(simulateResponse1);
            Assert.Equal(Transaction_modelState.PENDING, simulateResponse1.Transaction.State);

            var clearingModel = new ClearingModel
            {
                Amount = authRequest1.Amount,
                Original_transaction_token = simulateResponse1.Transaction.Token
            };
            var simulateClearingResponseModel = await client.SimulateClearingAsync(clearingModel);
            Assert.NotNull(simulateClearingResponseModel);
            Assert.Equal(Transaction_modelState.COMPLETION, simulateClearingResponseModel.Transaction.State);

            var balance2 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(fundingAmount - authRequest1.Amount, balance2.Gpa.Available_balance);

            // Transact 2 - This should be declined
            var simulateResponse2 = await client.SimulateAuthorizationAsync(authRequest1);
            Assert.NotNull(simulateResponse2);
            Assert.Equal(Transaction_modelState.DECLINED, simulateResponse2.Transaction.State);
            Assert.Equal("1834", simulateResponse2.Transaction.Response.Code);
            Assert.Equal("Exceeds withdrawal amount limit", simulateResponse2.Transaction.Response.Memo);
        }

        [Fact]
        public async void Ensure_resetting_velocity_control_allows()
        {
            // Get client / fixture
            var client = ClientFactory.GetMarqetaClient();
            var fixture = new Fixture();

            //
            // NB: Responses from other test classes have already had assertions run against them
            //
            // Get card product
            var cardProductResponse = await CardProductHelper.CreateCardProduct();

            // Create a program funding source
            var programFundingSourceResponse = await ProgramFundingHelper.CreateProgramFundingSource();

            // Create user account
            var cardHolderResponse = await UserHelper.CreateUser();

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
            Assert.Equal(Card_transition_responseState.ACTIVE, cardTransitionResponse.State);

            // Fund user account
            const double fundingAmount = 1000;
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = fundingAmount,
                Currency_code = "USD",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);
            var balances1 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(fundingAmount, balances1.Gpa.Available_balance);

            // Add velocity control
            const double velocityControlAmount = 10;
            var velocityControlRequest = new Velocity_control_request
            {
                Amount_limit = velocityControlAmount,
                Velocity_window = Velocity_control_requestVelocity_window.LIFETIME,
                Currency_code = "USD",
                Association = new Spend_control_association { User_token = cardHolderResponse.Token },
            };
            var vcResponse = await client.VelocitycontrolsPostAsync(velocityControlRequest);
            Assert.NotNull(vcResponse);

            // Transact 1 - This should succeed
            var authRequest1 = new Auth_request_model
            {
                Amount = velocityControlAmount,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateResponse1 = await client.SimulateAuthorizationAsync(authRequest1);
            Assert.NotNull(simulateResponse1);
            Assert.Equal(Transaction_modelState.PENDING, simulateResponse1.Transaction.State);

            var clearingModel = new ClearingModel
            {
                Amount = authRequest1.Amount,
                Original_transaction_token = simulateResponse1.Transaction.Token
            };
            var simulateClearingResponseModel = await client.SimulateClearingAsync(clearingModel);
            Assert.NotNull(simulateClearingResponseModel);
            Assert.Equal(Transaction_modelState.COMPLETION, simulateClearingResponseModel.Transaction.State);

            var balance2 = await client.BalancesAsync(cardHolderResponse.Token);
            Assert.Equal(fundingAmount - authRequest1.Amount, balance2.Gpa.Available_balance);

            // Transact 2 - This should be declined
            var simulateResponse2 = await client.SimulateAuthorizationAsync(authRequest1);
            Assert.NotNull(simulateResponse2);
            Assert.Equal(Transaction_modelState.DECLINED, simulateResponse2.Transaction.State);
            Assert.Equal("1834", simulateResponse2.Transaction.Response.Code);
            Assert.Equal("Exceeds withdrawal amount limit", simulateResponse2.Transaction.Response.Memo);
        }
    }
}