using System.Threading.Tasks;
using AutoFixture;
using Marqeta.Core.Abstractions;
using Xunit;

// ReSharper disable IdentifierTypo

namespace Marqeta.Core.Sdk.Tests
{
    public class ProgramFundingControlTests : BaseTests
    {
        [Fact]
        public async Task<Program_funding_source_response> FundingsourcesProgramPostAsync()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
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