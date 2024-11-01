using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Marqeta.Core.Sdk.IoC;

public class MarqetaClientFactory
{
    private readonly HttpClient _httpClient;

    public MarqetaClientFactory(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public  MarqetaClient GetClient(IAuthenticationProvider authenticationProvider) {
        return new  MarqetaClient(new HttpClientRequestAdapter(authenticationProvider, httpClient: _httpClient));
    }
}