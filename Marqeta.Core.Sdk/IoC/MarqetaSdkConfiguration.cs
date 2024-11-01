using Microsoft.Kiota.Abstractions;

namespace Marqeta.Core.Sdk.IoC;

public class MarqetaSdkConfiguration
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string BaseAddress { get; set; }
    public IRequestOption[] OptionsForHandlers { get; set; }
}