using System.Linq;
using System.Threading.Tasks;
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class UserTests : BaseTests
    {
        [Fact]
        public async Task UsersGetAsync()
        {
            var client = TestMarqetaClientFactory.Create();
            var response = await client.Users.GetAsync();
            Assert.NotNull(response);
            Assert.True(response.Count > 0);
        }

        [Fact]
        public async Task UsersPostAsync()
        {
            await UserHelper.CreateUser();
        }

        [Fact]
        public async Task UsersPostAsync_CreateChildren()
        {
            var client = TestMarqetaClientFactory.Create();

            // Create parent
            var cardHolderModel1 = new Card_holder_model();
            var response1 = await client.Users.PostAsync(cardHolderModel1);
            Assert.NotNull(response1);

            // Create child
            var cardHolderModel2 = new Card_holder_model
            {
                ParentToken = response1.Token,
                UsesParentAccount = true,
            };
            var response2 = await client.Users.PostAsync(cardHolderModel2);
            Assert.NotNull(response2);
            Assert.Equal(response1.Token, response2.ParentToken);
        }

        [Fact]
        public async Task UsersChildrenAsync()
        {
            var client = TestMarqetaClientFactory.Create();

            // Create parent
            var cardHolderModel1 = new Card_holder_model();
            var response1 = await client.Users.PostAsync(cardHolderModel1);
            Assert.NotNull(response1);

            // Create child
            var cardHolderModel2 = new Card_holder_model
            {
                ParentToken = response1.Token,
                UsesParentAccount = true,
            };
            var response2 = await client.Users.PostAsync(cardHolderModel2);
            Assert.NotNull(response2);
            Assert.Equal(response1.Token, response2.ParentToken);

            // Get children
            var response3 = await client.Users[response1.Token].Children.GetAsync();
            Assert.NotNull(response3);
            Assert.True(response3.Count > 0);
            var responseChild = response3.Data.First();
            Assert.NotNull(responseChild);
            Assert.Equal(response2.Token, responseChild.Token);
        }
    }
}