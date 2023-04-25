using System.Threading.Tasks;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class CardTests : BaseTests
    {
        internal static async Task<Card_transition_response> ActivateCard(string cardToken)
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();

            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardToken,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var response = await client.CardtransitionsPostAsync(cardTransitionRequest);
            Assert.NotNull(response);
            Assert.Equal(Card_transition_responseState.ACTIVE, response.State);

            return response;
        }

        internal static async Task<Card_response> CreateCard(string userToken, string cardProductToken)
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();

            // Create card
            var cardRequest = new Card_request
            {
                User_token = userToken,
                Card_product_token = cardProductToken,
            };
            var response = await client.CardsPostAsync(cardRequest);
            Assert.NotNull(response);
            Assert.Equal(Card_responseState.ACTIVE, response.State);

            return response;
        }
    }
}