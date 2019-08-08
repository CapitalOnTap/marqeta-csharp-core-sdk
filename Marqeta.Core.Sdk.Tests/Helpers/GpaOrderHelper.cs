using System.Threading.Tasks;
using Marqeta.Core.Abstractions;
using Marqeta.Core.Sdk.Tests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.Helpers
{
    public static class GpaOrderHelper
    {
        internal static async Task<Gpa_response> FundUserAccount(string userToken, string fundingSourceToken, double fundingAmount = 1000)
        {
            // Get client / fixture
            var client = ClientFactory.GetMarqetaClient();

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