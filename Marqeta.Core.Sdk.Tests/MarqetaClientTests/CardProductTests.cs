using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class CardProductTests : BaseTests
    {
        [Fact]
        public async void CardproductsGetAsync()
        {
            var client = TestMarqetaClientFactory.Create();
            var response = await client.CardproductsGetAsync();
            Assert.NotNull(response);
            Assert.True(response.Count > 0);
        }

        [Fact]
        public async void CardproductsPostAsync()
        {
            await CardProductHelper.CreateCardProduct();
        }
    }
}