using System;
using System.Net.Http;
using Marqeta.Core.Sdk.IoC;
using Microsoft.Extensions.DependencyInjection;
using IHttpMessageHandlerFactory = Marqeta.Core.Sdk.IoC.IHttpMessageHandlerFactory;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories
{
    internal static class TestMarqetaClientFactory
    {
        /// <summary>
        ///     Create a new instance of <see cref="MarqetaClient"/> for tests.
        /// </summary>
        /// <returns>The created <see cref="MarqetaClient"/> instance.</returns>
        public static MarqetaClient Create(Action<HttpClient> configureClient = null, IHttpMessageHandlerFactory httpMessageHandlerFactory = null)
        {
            var config = TestConfigurationFactory.Create();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMarqetaSdk(new MarqetaSdkConfiguration(
                Username: config["Marqeta:UserName"]!,
                Password: config["Marqeta:Password"]!),
                configureClient ?? (httpClient =>
                {
                    httpClient.BaseAddress = new Uri(config["Marqeta:BaseUrl"]!);
                }), httpMessageHandlerFactory);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider.GetRequiredService<MarqetaClient>();
        }
    }
}