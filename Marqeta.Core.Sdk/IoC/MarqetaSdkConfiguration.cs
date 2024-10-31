using Microsoft.Kiota.Abstractions;

namespace Marqeta.Core.Sdk.IoC;

public record MarqetaSdkConfiguration(string Username, string Password, IRequestOption[]? OptionsForHandlers = null);