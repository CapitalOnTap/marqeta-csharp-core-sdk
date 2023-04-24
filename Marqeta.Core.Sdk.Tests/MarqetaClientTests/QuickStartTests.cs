using System;
using AutoFixture;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class QuickStartTests : BaseTests
    {
        /// <summary>
        /// Marqeta quick start as described in the documentation
        /// </summary>
        /// <remarks>
        /// Link: https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api
        /// NB: We do not use any of the helper classes here as these tests are illustrative
        /// </remarks>
        [Fact]
        public async void QuickStart()
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();
            var fixture = new Fixture();

            //
            // Step 2: Create objects
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____create_objects
            //

            // Create card product
            var cardProductRequest = new Card_product_request
            {
                Start_date = DateTimeOffset.Now.Date,
                Name = fixture.Create<string>(),
                Config = new Card_product_config
                {
                    Fulfillment = new Card_product_fulfillment { Payment_instrument = Card_product_fulfillmentPayment_instrument.VIRTUAL_PAN },
                    Poi = new Poi { Ecommerce = true },
                    Card_life_cycle = new Card_life_cycle { Activate_upon_issue = true },
                }
            };
            var cardProductResponse = await client.CardproductsPostAsync(cardProductRequest);
            Assert.NotNull(cardProductResponse);

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
                Card_product_token = cardProductResponse.Token,
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


            //
            // Step 3: Fund user account
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____fund_user_account_
            //

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = 1000,
                Currency_code = "GBP",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);

            //
            // Step 4: Transact
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____transact_
            //

            // Transact
            var authRequest = new Auth_request_model
            {
                Amount = 10,
                Mid = fixture.Create<string>(),
                Card_token = cardResponse.Token,
            };
            var simulateResponse = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateResponse);
        }

        [Fact]
        public async void QuickStartWithWebhook()
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();
            var fixture = new Fixture();

            //
            // Step 2: Create objects
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____create_objects
            //

            // Create card product
            var cardProductRequest = new Card_product_request
            {
                Start_date = DateTimeOffset.Now.Date,
                Name = fixture.Create<string>(),
                Config = new Card_product_config
                {
                    Fulfillment = new Card_product_fulfillment { Payment_instrument = Card_product_fulfillmentPayment_instrument.VIRTUAL_PAN },
                    Poi = new Poi { Ecommerce = true },
                    Card_life_cycle = new Card_life_cycle { Activate_upon_issue = true },
                }
            };
            var cardProductResponse = await client.CardproductsPostAsync(cardProductRequest);
            Assert.NotNull(cardProductResponse);

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
                Card_product_token = cardProductResponse.Token,
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


            //
            // Step 3: Fund user account
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____fund_user_account_
            //

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                User_token = cardHolderResponse.Token,
                Amount = 1000,
                Currency_code = "GBP",
                Funding_source_token = programFundingSourceResponse.Token
            };
            var gpaResponse = await client.GpaordersPostAsync(gpaRequest);
            Assert.NotNull(gpaResponse);

            //
            // Step 4: Transact
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____transact_
            //
            // Step 5: Add a webhook
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____add_a_webhook
            //

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
            var simulateResponse = await client.SimulateAuthorizationAsync(authRequest);
            Assert.NotNull(simulateResponse);
        }
    }
}