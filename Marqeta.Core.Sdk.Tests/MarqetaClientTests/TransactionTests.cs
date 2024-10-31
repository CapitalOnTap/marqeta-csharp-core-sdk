using System.Threading.Tasks;
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
        public async Task Ensure_transaction_is_reversed()
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
            var pendingTransaction = await client.Simulate.Authorization.PostAsync(authRequest1);
            Assert.NotNull(pendingTransaction);
            Assert.Equal(Transaction_model_state.PENDING, pendingTransaction.Transaction.State);

            // Attempt reversal
            var reversalRequest = new AuthorizationreversalPostRequestBody
            {
                OriginalTransactionToken = pendingTransaction.Transaction.Token
            };

            var reversalResponse = await client.Transactions.Authorizationreversal.PostAsync(reversalRequest);
            Assert.NotNull(reversalResponse);

            Assert.Equal(Transaction_model_type.AuthorizationReversal, reversalResponse.Transaction.Type);
            Assert.Equal(Transaction_model_state.CLEARED, reversalResponse.Transaction.State);
            Assert.Equal(pendingTransaction.Transaction.Token, reversalResponse.Transaction.PrecedingRelatedTransactionToken);
        }
    }
}