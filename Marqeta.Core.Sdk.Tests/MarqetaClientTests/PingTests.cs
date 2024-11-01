using System.Threading.Tasks;
using AutoFixture;
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class PingTests : BaseTests
    {
        [Fact]
        public async Task PingGetAsync()
        {
            var client = TestMarqetaClientFactory.Create();
            var response = await client.Ping.GetAsync();
            Assert.NotNull(response);
            Assert.True(response.Success);
        }

        [Fact]
        public async Task PingPostAsync()
        {
            var client = TestMarqetaClientFactory.Create();
            var fixture = new Fixture();
            var echoPingRequest = fixture.Build<Echo_ping_request>()
                .Without(epr => epr.AdditionalData)
                .Create();
            var response = await client.Ping.PostAsync(echoPingRequest);
            Assert.NotNull(response);
            Assert.True(response.Success);
        }
    }
}