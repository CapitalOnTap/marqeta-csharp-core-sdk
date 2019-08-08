using Marqeta.Core.Sdk.Tests.Factories;
using Marqeta.Core.Sdk.Tests.Helpers;
using Xunit;

namespace Marqeta.Core.Sdk.Tests
{
    public class CardProductTests : BaseTests
    {
        [Fact]
        public async void CardproductsGetAsync()
        {
            var client = ClientFactory.GetMarqetaClient();
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