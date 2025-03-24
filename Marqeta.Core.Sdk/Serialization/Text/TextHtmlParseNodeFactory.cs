using System.ComponentModel;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Text;

namespace Marqeta.Core.Sdk.Serialization.Text;

/// <summary>
///     The <see cref="IAsyncParseNodeFactory"/> implementation for text/html content types
///     Copied from:  <see href="https://github.com/microsoft/kiota-dotnet/blob/main/src/serialization/text/TextParseNodeFactory.cs"/>
///     <see cref="TextParseNodeFactory"/>
/// </summary>
public class TextHtmlParseNodeFactory : IAsyncParseNodeFactory
{
    public string ValidContentType => "text/html";

    /// <inheritdoc />
    [Obsolete("Use GetRootParseNodeAsync instead")]
    [EditorBrowsable(EditorBrowsableState.Never)]
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
    
    /// <inheritdoc />
    public async Task<IParseNode> GetRootParseNodeAsync(string contentType, Stream content,
        CancellationToken cancellationToken = default)
    {
        if(string.IsNullOrEmpty(contentType))
            throw new ArgumentNullException(nameof(contentType));
        else if(!ValidContentType.Equals(contentType, StringComparison.OrdinalIgnoreCase))
            throw new ArgumentOutOfRangeException($"expected a {ValidContentType} content type");
            
        _ = content ?? throw new ArgumentNullException(nameof(content));
        using var reader = new StreamReader(content);
        var stringContent = await reader.ReadToEndAsync().ConfigureAwait(false);
        return new TextHtmlParseNode(stringContent);
    }
}