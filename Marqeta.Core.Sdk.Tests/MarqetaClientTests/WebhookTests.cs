using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class WebhookTests : BaseTests
    {
        [Fact]
        public void Test_Webhook_Resend_BuildsCorrectly()
        {
            var token = "test-webhook-token";
            var eventType = "transaction";
            var eventToken = "test-webhook-event-token";
            var client = TestMarqetaClientFactory.Create();
            
            var request = client.Webhooks[token][eventType][eventToken].ToPostRequestInformation();
            
            var requestToken = Assert.Contains("token", request.PathParameters);
            var requestEventType = Assert.Contains("event_type", request.PathParameters);
            var requestEventToken = Assert.Contains("event_token", request.PathParameters);
            Assert.Equal(token, requestToken);
            Assert.Equal(eventType, requestEventType);
            Assert.Equal(eventToken, requestEventToken);
            Assert.Equal("{+baseurl}/webhooks/{token}/{event_type}/{event_token}", request.UrlTemplate);
        }
    }
}