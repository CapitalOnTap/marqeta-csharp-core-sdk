using System.Threading.Tasks;
using AutoFixture;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers
{
    public static class ProgramFundingHelper
    {
        internal static async Task<Program_funding_source_response> CreateProgramFundingSource()
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();
            var fixture = new Fixture();

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = await client.FundingsourcesProgramPostAsync(programFundingSourceRequest);
            Assert.NotNull(programFundingSourceResponse);

            // Return for use in other tests
            return programFundingSourceResponse;
        }
    }
}