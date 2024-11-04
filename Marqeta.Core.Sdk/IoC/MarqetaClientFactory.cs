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
    ///     Takes an <see cref="IAuthenticationProvider"/>, creates a <see cref="HttpClientRequestAdapter"/> and
    ///     a <see cref="MarqetaClient"/>
    /// </summary>
    /// <param name="authenticationProvider">The authentication provider for Kiota to use when making requests.</param>
    /// <returns>Created <see cref="MarqetaClient"/></returns>
    public  MarqetaClient GetClient(IAuthenticationProvider authenticationProvider) {
        return new MarqetaClient(new HttpClientRequestAdapter(authenticationProvider, httpClient: _httpClient));
    }
}