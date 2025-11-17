using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Marqeta.Core.Sdk.IoC;

/// <summary>
///     Factory class to create a <see cref="MarqetaClient"/>.
/// </summary>
public class MarqetaClientFactory
{
    private readonly HttpClient _httpClient;

    public MarqetaClientFactory(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    /// <summary>
    ///     Takes an <see cref="IAuthenticationProvider"/> and optionally a custom adapter factory, creates an
    ///     <see cref="IRequestAdapter"/> and then a <see cref="MarqetaClient"/>.
    /// </summary>
    /// <param name="authenticationProvider">
    ///     The authentication provider for Kiota to use when making requests.
    /// </param>
    /// <param name="serviceProvider">
    ///     The service provider that can be used by <paramref name="adapterFactory"/> to resolve dependencies.
    /// </param>
    /// <param name="adapterFactory">
    ///     Optional factory function to create a custom <see cref="IRequestAdapter"/>.
    ///     If <c>null</c>, a default <see cref="HttpClientRequestAdapter"/> is used instead.
    /// </param>
    /// <returns>
    ///     A new instance of <see cref="MarqetaClient"/> configured with either a custom or default request adapter.
    /// </returns>
    public MarqetaClient GetClient(
        IAuthenticationProvider authenticationProvider,
        IServiceProvider serviceProvider,
        Func<IServiceProvider, HttpClient, IAuthenticationProvider, IRequestAdapter>? adapterFactory)
    {
        var baseAdapter = GetDefaultAdapter(authenticationProvider);
        var adapter = adapterFactory?.Invoke(serviceProvider, _httpClient, authenticationProvider) 
                      ?? baseAdapter;

        return new MarqetaClient(adapter);
    }
    
    private IRequestAdapter GetDefaultAdapter(IAuthenticationProvider authenticationProvider) =>
        new HttpClientRequestAdapter(authenticationProvider, httpClient: _httpClient);
}