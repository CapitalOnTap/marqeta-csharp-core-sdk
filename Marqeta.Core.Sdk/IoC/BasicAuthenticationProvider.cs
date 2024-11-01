using System.Diagnostics;
using System.Text;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace Marqeta.Core.Sdk.IoC;

public class BasicAuthenticationProvider : IAuthenticationProvider
{
    private const string HeaderName = "Authorization";
    private readonly string _credentials;
    public BasicAuthenticationProvider(string username, string password)
    {
        if(string.IsNullOrEmpty(username))
            throw new ArgumentNullException(nameof(username));
        if(string.IsNullOrEmpty(password))
            throw new ArgumentNullException(nameof(password));
        
        _credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
    }
    
    private static ActivitySource _activitySource = new(typeof(RequestInformation).Namespace!);

    public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
    {
        if(request == null)
            throw new ArgumentNullException(nameof(request));
        using var span = _activitySource?.StartActivity(nameof(AuthenticateRequestAsync));
        
        request.Headers.Add(HeaderName, $"Basic {_credentials}");
        return Task.CompletedTask;
    }
}