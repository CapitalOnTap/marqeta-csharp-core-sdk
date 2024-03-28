using System.Threading.Tasks;
using Marqeta.Core.Sdk.Models;
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
                CardToken = cardToken,
                State = Card_transition_request_state.ACTIVE,
                Channel = Card_transition_request_channel.API,
                ReasonCode = Card_transition_request_reason_code.ZeroZero
            };
            var response = await client.Cardtransitions.PostAsync(cardTransitionRequest);
            Assert.NotNull(response);
            Assert.Equal(Card_transition_response_state.ACTIVE, response.State);

            return response;
        }

        internal static async Task<Card_response> CreateCard(string userToken, string cardProductToken)
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();

            // Create card
            var cardRequest = new Card_request
            {
                UserToken = userToken,
                CardProductToken = cardProductToken,
            };
            var response = await client.Cards.PostAsync(cardRequest);
            Assert.NotNull(response);
            Assert.Equal(Card_response_state.ACTIVE, response.State);

            return response;
        }
    }
}