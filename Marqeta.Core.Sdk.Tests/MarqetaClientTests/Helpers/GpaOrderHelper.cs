using System.Threading.Tasks;
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers
{
    public static class GpaOrderHelper
    {
        internal static async Task<Gpa_response> FundUserAccount(string userToken, string fundingSourceToken, double fundingAmount = 1000)
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();

            // Check balance before funding
            var balances1 = await client.Balances[userToken].GetAsync();
            Assert.NotNull(balances1);

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                UserToken = userToken,
                Amount = fundingAmount,
                CurrencyCode = "GBP",
                FundingSourceToken = fundingSourceToken
            };
            var gpaResponse = await client.Gpaorders.PostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);

            // Ensure funds have been added
            var balances2 = await client.Balances[userToken].GetAsync();
            Assert.NotNull(balances2);
            Assert.Equal(balances1.Gpa.AvailableBalance + fundingAmount, balances2.Gpa.AvailableBalance);

            return gpaResponse;
        }
    }
}