using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Text;

namespace Marqeta.Core.Sdk.Serialization.Text;

/// <summary>
/// The <see cref="IAsyncParseNodeFactory"/> implementation for text/html content types
/// Copied from: https://github.com/microsoft/kiota-serialization-text-dotnet/blob/main/src/TextParseNodeFactory.cs
/// <see cref="TextParseNodeFactory"/>
/// </summary>
public class TextHtmlParseNodeFactory : IAsyncParseNodeFactory
{
    public string ValidContentType => "text/html";

    /// <inheritdoc />
    public async Task<IParseNode> GetRootParseNodeAsync(string contentType, Stream content,
        CancellationToken cancellationToken = new CancellationToken())
    {
        if(string.IsNullOrEmpty(contentType))
            throw new ArgumentNullException(nameof(contentType));
        else if(!ValidContentType.Equals(contentType, StringComparison.OrdinalIgnoreCase))
            throw new ArgumentOutOfRangeException($"expected a {ValidContentType} content type");
            
        _ = content ?? throw new ArgumentNullException(nameof(content));
        using var reader = new StreamReader(content);
        var stringContent = await reader.ReadToEndAsync();
        return new TextHtmlParseNode(stringContent);
    }

    /// <inheritdoc />
    public IParseNode GetRootParseNode(string contentType, Stream content) {
        if(string.IsNullOrEmpty(contentType))
            throw new ArgumentNullException(nameof(contentType));
        else if(!ValidContentType.Equals(contentType, StringComparison.OrdinalIgnoreCase))
            throw new ArgumentOutOfRangeException($"expected a {ValidContentType} content type");
            
        _ = content ?? throw new ArgumentNullException(nameof(content));
        using var reader = new StreamReader(content);
        var stringContent = reader.ReadToEnd();
        return new TextHtmlParseNode(stringContent);
    }
}