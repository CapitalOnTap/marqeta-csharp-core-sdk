using System;
using AutoFixture;
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Microsoft.Kiota.Abstractions;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests
{
    public class QuickStartTests : BaseTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public QuickStartTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

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
                StartDate = new Date(DateTimeOffset.Now.Date),
                Name = fixture.Create<string>(),
                Active = true,
                Config = new Card_product_config
                {
                    Fulfillment = new Card_product_fulfillment { PaymentInstrument = Card_product_fulfillment_payment_instrument.VIRTUAL_PAN },
                    Poi = new Poi { Ecommerce = true },
                    CardLifeCycle = new Card_life_cycle { ActivateUponIssue = true },
                }
            };
            var cardProductResponse = await client.Cardproducts.PostAsync(cardProductRequest);
            Assert.NotNull(cardProductResponse);

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.AdditionalData)
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = await client.Fundingsources.Program.PostAsync(programFundingSourceRequest);
            Assert.NotNull(programFundingSourceResponse);

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = await client.Users.PostAsync(cardHolderModel);
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                UserToken = cardHolderResponse.Token,
                CardProductToken = cardProductResponse.Token,
            };
            var cardResponse = await client.Cards.PostAsync(cardRequest);
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                CardToken = cardResponse.Token,
                State = Card_transition_request_state.ACTIVE,
                Channel = Card_transition_request_channel.API,
                ReasonCode = Card_transition_request_reason_code.ZeroZero
            };
            try
            {
                var cardTransitionResponse = await client.Cardtransitions.PostAsync(cardTransitionRequest);
                Assert.NotNull(cardTransitionResponse);
            }
            catch (Exception ex)
            {
                _testOutputHelper.WriteLine(ex.ToString());
            }
            


            //
            // Step 3: Fund user account
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____fund_user_account_
            //

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                UserToken = cardHolderResponse.Token,
                Amount = 1000,
                CurrencyCode = "USD",
                FundingSourceToken = programFundingSourceResponse.Token
            };
            var gpaResponse = await client.Gpaorders.PostAsync(gpaRequest);
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
                CardToken = cardResponse.Token,
            };
            try
            {
                var simulateResponse = await client.Simulate.Authorization.PostAsync(authRequest);
                Assert.NotNull(simulateResponse);
            }
            catch (Exception ex)
            {
                _testOutputHelper.WriteLine(ex.ToString());
            }
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
                StartDate = new Date(DateTimeOffset.Now.Date),
                Name = fixture.Create<string>(),
                Active = true,
                Config = new Card_product_config
                {
                    Fulfillment = new Card_product_fulfillment { PaymentInstrument = Card_product_fulfillment_payment_instrument.VIRTUAL_PAN },
                    Poi = new Poi { Ecommerce = true },
                    CardLifeCycle = new Card_life_cycle { ActivateUponIssue = true },
                }
            };
            var cardProductResponse = await client.Cardproducts.PostAsync(cardProductRequest);
            Assert.NotNull(cardProductResponse);

            // Create a program funding sources
            var programFundingSourceRequest = fixture.Build<Program_funding_source_request>()
                .Without(pfsr => pfsr.AdditionalData)
                .Without(pfsr => pfsr.Active)
                .Without(pfsr => pfsr.Token)
                .Create();
            var programFundingSourceResponse = await client.Fundingsources.Program.PostAsync(programFundingSourceRequest);
            Assert.NotNull(programFundingSourceResponse);

            // Create user account
            var cardHolderModel = new Card_holder_model();
            var cardHolderResponse = await client.Users.PostAsync(cardHolderModel);
            Assert.NotNull(cardHolderResponse);

            // Create card
            var cardRequest = new Card_request
            {
                UserToken = cardHolderResponse.Token,
                CardProductToken = cardProductResponse.Token,
            };
            var cardResponse = await client.Cards.PostAsync(cardRequest);
            Assert.NotNull(cardResponse);

            // Activate card
            var cardTransitionRequest = new Card_transition_request
            {
                CardToken = cardResponse.Token,
                State = Card_transition_request_state.ACTIVE,
                Channel = Card_transition_request_channel.API,
                ReasonCode = Card_transition_request_reason_code.ZeroZero
            };
            var cardTransitionResponse = await client.Cardtransitions.PostAsync(cardTransitionRequest);
            Assert.NotNull(cardTransitionResponse);


            //
            // Step 3: Fund user account
            // https://www.marqeta.com/api/guides/WIlA2isAAMkAsk6F/quick-start--marqeta-api#step_____fund_user_account_
            //

            // Fund user account
            var gpaRequest = new Gpa_request
            {
                UserToken = cardHolderResponse.Token,
                Amount = 1000,
                CurrencyCode = "USD",
                FundingSourceToken = programFundingSourceResponse.Token
            };
            var gpaResponse = await client.Gpaorders.PostAsync(gpaRequest);
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
                CardToken = cardResponse.Token,
                Webhook = new Webhook
                {
                    Endpoint = "https://quick-start-guide.free.beeceptor.com",
                    Username = fixture.Create<string>(),
                    Password = fixture.Create<string>()
                }
            };
            var simulateResponse = await client.Simulate.Authorization.PostAsync(authRequest);
            Assert.NotNull(simulateResponse);
        }
    }
}