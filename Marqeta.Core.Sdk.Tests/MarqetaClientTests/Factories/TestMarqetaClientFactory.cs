using System;
using System.Text;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories
{
    internal static class TestMarqetaClientFactory
    {
        /// <summary>
        ///     Create a new instance of <see cref="IMarqetaClient"/> for tests.
        /// </summary>
        /// <returns>The created <see cref="IMarqetaClient"/> instance.</returns>
        public static MarqetaClient Create()
        {
            var config = TestConfigurationFactory.Create();
            var apiKey = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{config["Marqeta:UserName"]}:{config["Marqeta:Password"]}"));
            var authProvider = new ApiKeyAuthenticationProvider(
                $"Basic {apiKey}",
                "Authorization",
                ApiKeyAuthenticationProvider.KeyLocation.Header);
            var adapter = new HttpClientRequestAdapter(authProvider)
            {
                BaseUrl = config["Marqeta:BaseUrl"]
            };

            return new MarqetaClient(adapter);
        }
    }
}