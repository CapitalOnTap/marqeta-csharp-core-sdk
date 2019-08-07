using System.Linq;
using AutoFixture;
using Marqeta.Core.Abstractions;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public class QuickStartTests : BaseTests
    {
        public QuickStartTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
        
        [Fact]
        public void QuickStart()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Get the latest card product
            var cardProductToken = client.CardproductsGetAsync().Result.Data
                .OrderByDescending(x => x.Last_modified_time).First().Token;
            Assert.NotEmpty(cardProductToken);

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = client.FundingsourcesProgramPostAsync(programFundingSourceRequest).Result;
            Assert.NotNull(programFundingSourceResponse);

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = cardProductToken,
            };
            var cardResponse = client.CardsPostAsync(cardRequest).Result;
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = client.CardtransitionsPostAsync(cardTransitionRequest).Result;
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = 1000,
                //Currency_code = "GBP",
                Currency_code = "USD",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = client.GpaordersPostAsync(gpaRequest).Result;
            Assert.NotNull(gpaResponse);

            // Transact
            var authRequest = new Auth_request_model
            {
                Amount = 10,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateResponse);
        }

        [Fact]
        public void QuickStartWithWebhook()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Get the latest card product
            var cardProductToken = client.CardproductsGetAsync().Result.Data
                .OrderByDescending(x => x.Last_modified_time).First().Token;
            Assert.NotEmpty(cardProductToken);

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = client.FundingsourcesProgramPostAsync(programFundingSourceRequest).Result;
            Assert.NotNull(programFundingSourceResponse);

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = client.UsersPostAsync(cardHolderModel).Result;
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = cardProductToken,
            };
            var cardResponse = client.CardsPostAsync(cardRequest).Result;
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = client.CardtransitionsPostAsync(cardTransitionRequest).Result;
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = 1000,
                //Currency_code = "GBP",
                Currency_code = "USD",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = client.GpaordersPostAsync(gpaRequest).Result;
            Assert.NotNull(gpaResponse);

            // Transact
            var authRequest = new Auth_request_model
            {
                Amount = 10,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
                Webhook = new Webhook
                {
                    Endpoint = "https://quick-start-guide.free.beeceptor.com",
                    Username = fixture.Create<string>(),
                    Password = fixture.Create<string>()
                }
            };
            var simulateResponse = client.SimulateAuthorizationAsync(authRequest).Result;
            Assert.NotNull(simulateResponse);
        }
    }
}