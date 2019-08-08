﻿using AutoFixture;
using Marqeta.Core.Abstractions;
using Xunit;

// ReSharper disable IdentifierTypo

namespace Marqeta.Core.Sdk.Tests
{
    public class PingTests : BaseTests
    {
        [Fact]
        public async void PingGetAsync()
        {
            var client = GetMarqetaClient();
            var response = await client.PingGetAsync();
            Assert.NotNull(response);
            Assert.True(response.Success);
        }

        [Fact]
        public async void PingPostAsync()
        {
            var client = GetMarqetaClient();
            var fixture = new Fixture();
            var echoPingRequest = fixture.Create<Echo_ping_request>();
            var response = await client.PingPostAsync(echoPingRequest);
            Assert.NotNull(response);
            Assert.True(response.Success);
        }
    }
}