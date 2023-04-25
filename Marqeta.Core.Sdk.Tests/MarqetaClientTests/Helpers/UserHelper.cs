using System.Threading.Tasks;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers
{
    public static class UserHelper
    {
        internal static async Task<User_card_holder_response> CreateUser()
        {
            var client = TestMarqetaClientFactory.Create();
            var cardHolderModel = new Card_holder_model();
            var response = await client.UsersPostAsync(cardHolderModel);
            Assert.NotNull(response);
            return response;
        }
    }
}