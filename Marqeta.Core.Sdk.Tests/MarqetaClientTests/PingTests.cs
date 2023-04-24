using AutoFixture;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class PingTests : BaseTests
    {
        [Fact]
        public async void PingGetAsync()
        {
            var client = TestMarqetaClientFactory.Create();
            var response = await client.PingGetAsync();
            Assert.NotNull(response);
            Assert.True(response.Success);
        }

        [Fact]
        public async void PingPostAsync()
        {
            var client = TestMarqetaClientFactory.Create();
            var fixture = new Fixture();
            var echoPingRequest = fixture.Create<Echo_ping_request>();
            var response = await client.PingPostAsync(echoPingRequest);
            Assert.NotNull(response);
            Assert.True(response.Success);
        }
    }
}