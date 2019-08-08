using System.Threading.Tasks;
using AutoFixture;
using Marqeta.Core.Abstractions;
using Xunit;

// ReSharper disable IdentifierTypo

namespace Marqeta.Core.Sdk.Tests
{
    public class GpaOrderTests : BaseTests
    {
        [Fact]
        public async void GpaordersPostAsync()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            //
            // NB: Responses from other test classes have already had assertions run against them
            //
            // Get card product
            var cardProductResponse = await new CardProductTests().CardproductsPostAsync();

            // Create a program funding source
            var programFundingSourceResponse = await new ProgramFundingControlTests().FundingsourcesProgramPostAsync();

            // Create user account
            var cardHolderResponse = await new UserTests().UsersPostAsync();

            // Create / activate card
            var cardResponse = await CardTests.CreateCard(cardHolderResponse.Token, cardProductResponse.Token);
            //await CardTests.ActivateCard(cardResponse.Token);

            // Fund user account
            const double fundingAmount = 1000;
            await FundUserAccount(cardHolderResponse.Token, programFundingSourceResponse.Token, fundingAmount);

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

        internal static async Task<Gpa_response> FundUserAccount(string userToken, string fundingSourceToken, double fundingAmount = 1000)
        {
            // Get client / fixture
            var client = GetMarqetaClient();

            // Check balance before funding
            var balances1 = await client.BalancesAsync(userToken);
            Assert.NotNull(balances1);

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = userToken,
                Amount = fundingAmount,
                Currency_code = "USD",
                Funding_source_token = fundingSourceToken
            };
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);

            // Ensure funds have been added
            var balances2 = await client.BalancesAsync(userToken);
            Assert.NotNull(balances2);
            Assert.Equal(balances1.Gpa.Available_balance + fundingAmount, balances2.Gpa.Available_balance);

            return gpaResponse;
        }
    }
}