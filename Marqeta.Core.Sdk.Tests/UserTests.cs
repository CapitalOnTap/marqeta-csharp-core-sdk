using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public class UserTests : BaseTests
    {
        public UserTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        [Fact]
        public async void UsersGetAsync()
        {
            var client = GetMarqetaClient();
            var response = await client.UsersGetAsync();
            Assert.NotNull(response);
            Assert.True(response.Count > 0);
        }
    }
}