using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Marqeta.Core.Sdk.IoC;

/// <summary>
///     Extension method for <see cref="IServiceCollection"/> to register <see cref="MarqetaClient"/>
///     and its Kiota dependencies.
/// </summary>
public static class MarqetaSdkServiceCollectionExtensions
{
    /// <summary>
    ///     Registers all SDK dependencies required to use <see cref="MarqetaClient"/>
    ///     into the specified <paramref name="services"/>, using the provided
    ///     <paramref name="configuration"/> to build the client. After this is done, an
    ///     instance of the client can be injected and used.
    /// </summary>
    /// <param name="services">Service collection to add dependencies to.</param>
    /// <param name="configuration">Configuration to use for registering the client.</param>
    /// <param name="configureClient">Configure <see cref="HttpClient"/>.</param>
    /// <param name="httpMessageHandlerFactory">Provide a factory to create a <see cref="HttpMessageHandler"/>.</param>
    /// <param name="authenticationProviderFactory">Provide a factory to create an <see cref="IAuthenticationProvider"/>.</param>
    /// <returns>The <paramref name="services"/>.</returns>
    public static IHttpClientBuilder AddMarqetaSdk(
        this IServiceCollection services, 
        MarqetaSdkConfiguration configuration, 
        Action<HttpClient> configureClient, 
        Func<HttpMessageHandler> httpMessageHandlerFactory = null, 
        Func<MarqetaSdkConfiguration, IAuthenticationProvider> authenticationProviderFactory = null) =>
            // based on https://github.com/microsoft/kiota-samples/blob/main/get-started/dotnet-dependency-injection
            // and https://nikiforovall.github.io/dotnet/aspnetcore/2024/03/24/kiota-guide-deep-dive.html
            // and https://learn.microsoft.com/en-us/openapi/kiota/tutorials/dotnet-dependency-injection
            (configureClient is null ? 
                services.AddHttpClient<MarqetaClient>("MarqetaClient") : // If no configureClient is passed in, create default
                services.AddHttpClient<MarqetaClient>("MarqetaClient", configureClient))
                    .AddTypedClient((httpClient, _) =>
                    {
                        // Prioritise the httpClient.BaseAddress
                        httpClient.BaseAddress ??= new Uri(configuration.BaseAddress); 
                        // Allow override of the IAuthenticationProvider
                        var authenticationProvider = authenticationProviderFactory?.Invoke(configuration) ?? new BasicAuthenticationProvider(configuration.Username, configuration.Password);
                        return new MarqetaClientFactory(httpClient).GetClient(authenticationProvider);
                    })
                    .ConfigurePrimaryHttpMessageHandler(_ =>
                    {
                        // Creates the default handlers based on passed in configuration
                        var defaultHandlers = KiotaClientFactory.CreateDefaultHandlers(configuration.OptionsForHandlers);
                        // Retrieve the handler we want to inject in the end of the chain, or use the default Kiota HttpMessageHandler
                        var finalHandler = httpMessageHandlerFactory?.Invoke() ?? KiotaClientFactory.GetDefaultHttpMessageHandler();
                        return KiotaClientFactory.ChainHandlersCollectionAndGetFirstLink(finalHandler, [.. defaultHandlers])!;
                    });
}