using System;
using System.Threading.Tasks;
using AutoFixture;
using Marqeta.Core.Abstractions;
using Marqeta.Core.Sdk.Tests.Factories;
using Xunit;

// ReSharper disable IdentifierTypo

namespace Marqeta.Core.Sdk.Tests.Helpers
{
    public static class CardProductHelper
    {
        internal static async Task<Card_product_response> CreateCardProduct()
        {
            // Get client / fixture
            var client = ClientFactory.GetMarqetaClient();
            var fixture = new Fixture();

            // Create CardProduct
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

            // Return for use in other tests
            return cardProductResponse;
        }
    }
}