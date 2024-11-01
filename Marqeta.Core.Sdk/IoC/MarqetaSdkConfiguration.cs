using Microsoft.Kiota.Abstractions;

namespace Marqeta.Core.Sdk.IoC;

/// <summary>
///     Configuration for registering <see cref="MarqetaClient"/> and its Kiota dependencies.
/// </summary>
public class MarqetaSdkConfiguration
{
    /// <summary>
    ///     Marqeta Username used for Basic Authentication.
    /// </summary>
    public string Username { get; set; }
    
    /// <summary>
    ///     Marqeta Password used for Basic Authentication.
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    ///     Base Address to use for Marqeta API calls.
    /// </summary>
    public string BaseAddress { get; set; }
    
    /// <summary>
    ///     Kiota Request options to configure kiota middleware handlers.
    ///     <see href="https://github.com/microsoft/kiota-dotnet/tree/main/src/http/httpClient/Middleware/Options"/>
    /// </summary>
    public IRequestOption[] OptionsForHandlers { get; set; }
}