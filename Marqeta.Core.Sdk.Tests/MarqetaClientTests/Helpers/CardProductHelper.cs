using System;
using System.Threading.Tasks;
using AutoFixture;
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories;
using Microsoft.Kiota.Abstractions;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Helpers
{
    public static class CardProductHelper
    {
        internal static async Task<Card_product_response> CreateCardProduct()
        {
            // Get client / fixture
            var client = TestMarqetaClientFactory.Create();
            var fixture = new Fixture();

            // Create CardProduct
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

            // Return for use in other tests
            return cardProductResponse;
        }
    }
}