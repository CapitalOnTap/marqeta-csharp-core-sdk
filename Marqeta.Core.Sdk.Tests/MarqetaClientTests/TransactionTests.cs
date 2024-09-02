using AutoFixture;
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers;
using Marqeta.Core.Sdk.Transactions.Authorizationreversal;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class TransactionTests : BaseTests
    {
        [Fact]
        public async void Ensure_velocity_control_lifetime_is_honoured()
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();
            var fixture = new Fixture();

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

            // Transaction that will be pending and reversed
            var authRequest1 = new Auth_request_model
            {
                Amount = 1500,
                Mid = fixture.Create<string>(),
                CardToken = cardResponse.Token,
            };
            var simulateResponse1 = await client.Simulate.Authorization.PostAsync(authRequest1);
            Assert.NotNull(simulateResponse1);
            Assert.Equal(Transaction_model_state.PENDING, simulateResponse1.Transaction.State);

            // Attempt reversal
            var reversalRequest = new AuthorizationreversalPostRequestBody
            {
                OriginalTransactionToken = simulateResponse1.Transaction.Token
            };

            var updatedResponse = await client.Transactions.Authorizationreversal.PostAsync(reversalRequest);

            Assert.NotNull(updatedResponse);
            Assert.Equal(Transaction_model_state.COMPLETION, updatedResponse.State);
        }
    }
}