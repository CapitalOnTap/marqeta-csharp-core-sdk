using System.Diagnostics;
using System.Text;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace Marqeta.Core.Sdk.IoC;

/// <summary>
///     Default Basic Authentication provider for Kiota to use as part of <see cref="MarqetaClient"/>.
/// </summary>
public class BasicAuthenticationProvider : IAuthenticationProvider
{
    private const string HeaderName = "Authorization";
    private readonly string _credentials;
    public BasicAuthenticationProvider(string username, string password)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentNullException(nameof(username));
        }

        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentNullException(nameof(password));
        }
        
        _credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
    }
    
    private static ActivitySource _activitySource = new(typeof(RequestInformation).Namespace!);

    /// <summary>
    ///     Authenticates a request going through the Kiota generated <see cref="MarqetaClient"/>
    ///     by adding a header with the Basic Authentication credentials.
    /// </summary>
    /// <param name="request">Kiota request.</param>
    /// <param name="additionalAuthenticationContext">Unused.</param>
    /// <param name="cancellationToken">Unused.</param>
    /// <returns><see cref="Task"/></returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is null.</exception>
    public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
    {
        if (request == null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        using var span = _activitySource?.StartActivity(nameof(AuthenticateRequestAsync));
        
        request.Headers.Add(HeaderName, $"Basic {_credentials}");
        return Task.CompletedTask;
    }
}