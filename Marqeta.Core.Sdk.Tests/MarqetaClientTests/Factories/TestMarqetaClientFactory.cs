using System;
using System.Net.Http;
using Marqeta.Core.Sdk.IoC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions.Authentication;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories
{
    internal static class TestMarqetaClientFactory
    {
        /// <summary>
        ///     Create a new instance of <see cref="MarqetaClient"/> for tests.
        /// </summary>
        /// <returns>The created <see cref="MarqetaClient"/> instance.</returns>
        public static MarqetaClient Create(Action<HttpClient> configureClient = null, Func<HttpMessageHandler> httpMessageHandlerFactory = null, Func<MarqetaSdkConfiguration, IAuthenticationProvider> authenticationProviderFactory = null)
        {
            var config = TestConfigurationFactory.Create();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMarqetaSdk(
                new MarqetaSdkConfiguration{
                    Username = config["Marqeta:UserName"]!,
                    Password = config["Marqeta:Password"]!,
                    BaseAddress = config["Marqeta:BaseUrl"]
                },
                configureClient, 
                httpMessageHandlerFactory,
                authenticationProviderFactory);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider.GetRequiredService<MarqetaClient>();
        }
    }
}