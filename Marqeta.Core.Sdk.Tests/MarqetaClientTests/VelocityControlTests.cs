using System.Threading.Tasks;
using AutoFixture;
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class VelocityControlTests : BaseTests
    {
        [Fact]
        public async Task Ensure_velocity_control_lifetime_is_honoured()
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();
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

            // Fund user account
            const double fundingAmount = 1000;
            await GpaOrderHelper.FundUserAccount(cardHolderResponse.Token, programFundingSourceResponse.Token, fundingAmount);

            // Add velocity control
            const double velocityControlAmount = 10;
            var velocityControlRequest = new Velocity_control_request
            {
                AmountLimit = velocityControlAmount,
                VelocityWindow = Velocity_control_request_velocity_window.LIFETIME,
                CurrencyCode = "USD",
                Association = new Spend_control_association { UserToken = cardHolderResponse.Token },
            };
            var vcResponse = await client.Velocitycontrols.PostAsync(velocityControlRequest);
            Assert.NotNull(vcResponse);

            // Transact 1 - This should succeed
            var authRequest1 = new Auth_request_model
            {
                Amount = velocityControlAmount,
                Mid = fixture.Create<string>(),
                CardToken = cardResponse.Token,
            };
            var simulateResponse1 = await client.Simulate.Authorization.PostAsync(authRequest1);
            Assert.NotNull(simulateResponse1);
            Assert.Equal(Transaction_model_state.PENDING, simulateResponse1.Transaction.State);

            var clearingModel = new ClearingModel
            {
                Amount = authRequest1.Amount,
                OriginalTransactionToken = simulateResponse1.Transaction.Token
            };
            var simulateClearingResponseModel = await client.Simulate.Clearing.PostAsync(clearingModel);
            Assert.NotNull(simulateClearingResponseModel);
            Assert.Equal(Transaction_model_state.COMPLETION, simulateClearingResponseModel.Transaction.State);

            var balance2 = await client.Balances[cardHolderResponse.Token].GetAsync();
            Assert.Equal(fundingAmount - authRequest1.Amount, balance2.Gpa.AvailableBalance);

            // Transact 2 - This should be declined
            var simulateResponse2 = await client.Simulate.Authorization.PostAsync(authRequest1);
            Assert.NotNull(simulateResponse2);
            Assert.Equal(Transaction_model_state.DECLINED, simulateResponse2.Transaction.State);
            Assert.Equal("1834", simulateResponse2.Transaction.Response.Code);
            Assert.Equal("Exceeds withdrawal amount limit", simulateResponse2.Transaction.Response.Memo);
        }

        [Fact]
        public async Task Ensure_resetting_velocity_control_allows()
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();
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

            // Fund user account
            const double fundingAmount = 1000;
            await GpaOrderHelper.FundUserAccount(cardHolderResponse.Token, programFundingSourceResponse.Token, fundingAmount);

            // Add velocity control
            const double velocityControlAmount = 10;
            var velocityControlRequest = new Velocity_control_request
            {
                AmountLimit = velocityControlAmount,
                VelocityWindow = Velocity_control_request_velocity_window.LIFETIME,
                CurrencyCode = "USD",
                Association = new Spend_control_association { UserToken = cardHolderResponse.Token },
            };
            var vcResponse = await client.Velocitycontrols.PostAsync(velocityControlRequest);
            Assert.NotNull(vcResponse);

            // Transact 1 - This should succeed
            var authRequest1 = new Auth_request_model
            {
                Amount = velocityControlAmount,
                Mid = fixture.Create<string>(),
                CardToken = cardResponse.Token,
            };
            var simulateResponse1 = await client.Simulate.Authorization.PostAsync(authRequest1);
            Assert.NotNull(simulateResponse1);
            Assert.Equal(Transaction_model_state.PENDING, simulateResponse1.Transaction.State);

            var clearingModel = new ClearingModel
            {
                Amount = authRequest1.Amount,
                OriginalTransactionToken = simulateResponse1.Transaction.Token
            };
            var simulateClearingResponseModel = await client.Simulate.Clearing.PostAsync(clearingModel);
            Assert.NotNull(simulateClearingResponseModel);
            Assert.Equal(Transaction_model_state.COMPLETION, simulateClearingResponseModel.Transaction.State);

            var balance2 = await client.Balances[cardHolderResponse.Token].GetAsync();
            Assert.Equal(fundingAmount - authRequest1.Amount, balance2.Gpa.AvailableBalance);

            // Transact 2 - This should be declined
            var simulateResponse2 = await client.Simulate.Authorization.PostAsync(authRequest1);
            Assert.NotNull(simulateResponse2);
            Assert.Equal(Transaction_model_state.DECLINED, simulateResponse2.Transaction.State);
            Assert.Equal("1834", simulateResponse2.Transaction.Response.Code);
            Assert.Equal("Exceeds withdrawal amount limit", simulateResponse2.Transaction.Response.Memo);
        }
    }
}