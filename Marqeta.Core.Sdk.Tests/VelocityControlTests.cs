using System.Linq;
using AutoFixture;
using Marqeta.Core.Abstractions;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public class VelocityControlTests : BaseTests
    {
        public VelocityControlTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        [Fact]
        public async void Test1()
        {
            // Get client / fixture
            var client = GetMarqetaClient();
            var fixture = new Fixture();

            // Get the latest card product
            var cardProductToken = (await client.CardproductsGetAsync())
                .Data.OrderByDescending(x => x.Last_modified_time).First().Token;
            Assert.NotEmpty(cardProductToken);

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = await client.FundingsourcesProgramPostAsync(programFundingSourceRequest);
            Assert.NotNull(programFundingSourceResponse);

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = await client.UsersPostAsync(cardHolderModel);
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                User_token = cardHolderResponse.Token,
                Card_product_token = cardProductToken,
            };
            var cardResponse = await client.CardsPostAsync(cardRequest);
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                Card_token = cardResponse.Token,
                State = Card_transition_requestState.ACTIVE,
                Channel = Card_transition_requestChannel.API,
                Reason_code = Card_transition_requestReason_code._00
            };
            var cardTransitionResponse = await client.CardtransitionsPostAsync(cardTransitionRequest);
            Assert.NotNull(cardTransitionResponse);

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = 1000,
                Currency_code = "USD",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);

            // Add velocity control
            var velocityControlRequest = new Velocity_control_request
            {
                // Token - Perhaps set this?
                Amount_limit = 10,
                // Pending question with Marqeta
                Velocity_window = Velocity_control_requestVelocity_window.LIFETIME,
                //Velocity_window = Velocity_control_requestVelocity_window.MONTH,
                Currency_code = "USD",
                Association = new Spend_control_association { User_token = cardHolderResponse.Token },
            };
            var vcResponse = await client.VelocitycontrolsPostAsync(velocityControlRequest);

            // Transact 1
            var authRequest = new Auth_request_model
            {
                Amount = 10,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateResponse = client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateResponse);

            // Transact 2
            var simulateResponse2 = client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateResponse2);
        }
    }
}