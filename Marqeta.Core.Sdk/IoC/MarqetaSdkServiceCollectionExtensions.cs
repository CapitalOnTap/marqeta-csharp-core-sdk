using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Marqeta.Core.Sdk.IoC;

public static class MarqetaSdkServiceCollectionExtensions
{
    /// <summary>
    /// Registers all SDK dependencies required to use <see cref="MarqetaClient"/>
    /// into the specified <paramref name="services"/>, using the provided
    /// <paramref name="configuration"/> to build the client. After this is done, an
    /// instance of the client can be injected and used.
    /// </summary>
    /// <param name="services">Service collection to add dependencies to.</param>
    /// <param name="configuration">Configuration to use for registering the client.</param>
    /// <param name="configureClient"></param>
    /// <param name="httpMessageHandlerFactory"></param>
    /// <returns>The <paramref name="services"/>.</returns>
    public static IServiceCollection AddMarqetaSdk(this IServiceCollection services,  MarqetaSdkConfiguration configuration, Action<HttpClient> configureClient, Func<HttpMessageHandler>? httpMessageHandlerFactory = null)
    {
        services.AddSingleton<IAuthenticationProvider, BasicAuthenticationProvider>(
            _ => new BasicAuthenticationProvider(configuration.Username, configuration.Password));
        
        AddMarqetaClient(
            services,
            configuration,
            configureClient,
            httpMessageHandlerFactory);
        return services;
    }
    
    internal static IHttpClientBuilder AddMarqetaClient(IServiceCollection services, MarqetaSdkConfiguration configuration, Action<HttpClient> configureClient, Func<HttpMessageHandler>? httpMessageHandlerFactory = null) =>
        // based on https://github.com/microsoft/kiota-samples/blob/main/get-started/dotnet-dependency-injection
        // and https://nikiforovall.github.io/dotnet/aspnetcore/2024/03/24/kiota-guide-deep-dive.html
        services.AddHttpClient<MarqetaClient>("MarqetaSdkClient", configureClient)
            .AddTypedClient((httpClient, sp) =>
            {
                var authenticationProvider = sp.GetRequiredService<IAuthenticationProvider>();
                var requestAdapter = new HttpClientRequestAdapter(authenticationProvider , httpClient: httpClient);

                return new MarqetaClient(requestAdapter);
            })
            .ConfigurePrimaryHttpMessageHandler(_ =>
            {
                var defaultHandlers = KiotaClientFactory.CreateDefaultHandlers(configuration.OptionsForHandlers);
                var defaultHttpMessageHandler = httpMessageHandlerFactory?.Invoke() ?? KiotaClientFactory.GetDefaultHttpMessageHandler();
                return KiotaClientFactory.ChainHandlersCollectionAndGetFirstLink(defaultHttpMessageHandler, [.. defaultHandlers])!;
            });
}