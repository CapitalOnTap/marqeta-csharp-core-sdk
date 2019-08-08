using System;
using System.Threading.Tasks;
using AutoFixture;
using Marqeta.Core.Abstractions;
using Marqeta.Core.Sdk.Tests.Factories;
using Marqeta.Core.Sdk.Tests.Helpers;
using Xunit;

// ReSharper disable IdentifierTypo

namespace Marqeta.Core.Sdk.Tests
{
    public class CardProductTests : BaseTests
    {
        [Fact]
        public async void CardproductsGetAsync()
        {
            var client = ClientFactory.GetMarqetaClient();
            var response = await client.CardproductsGetAsync();
            Assert.NotNull(response);
            Assert.True(response.Count > 0);
        }

        [Fact]
        public async void CardproductsPostAsync()
        {
            await CardProductHelper.CreateCardProduct();
        }
    }
}