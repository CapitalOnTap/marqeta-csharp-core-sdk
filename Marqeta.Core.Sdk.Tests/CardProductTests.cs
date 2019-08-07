using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public class CardProductTests : BaseTests
    {
        public CardProductTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        [Fact]
        public void CardProducts()
        {
            var client = GetMarqetaClient();
            var response = client.CardproductsGetAsync().Result;
            Assert.NotNull(response);
            Assert.True(response.Count > 0);
        }
    }
}