using System.ComponentModel;
using System.Text.Json;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;

namespace Marqeta.Core.Sdk.Serialization.Json
{
    /// <summary>
    /// The <see cref="IAsyncParseNodeFactory"/> implementation for json content types.
    /// Copied from https://github.com/microsoft/kiota-serialization-json-dotnet/blob/main/src/JsonParseNodeFactory.cs
    /// <see cref="JsonParseNodeFactory"/>
    /// </summary>
    public class CustomJsonParseNodeFactory : IAsyncParseNodeFactory
    {
        private readonly KiotaJsonSerializationContext _jsonJsonSerializationContext;
        
        /// <summary>
        /// The <see cref="JsonParseNodeFactory"/> constructor.
        /// </summary>
        public CustomJsonParseNodeFactory()
        {
            _jsonJsonSerializationContext = new(new JsonSerializerOptions(JsonSerializerDefaults.Web));
        }
        
        /// <summary>
        /// The valid content type for json
        /// </summary>
        public string ValidContentType { get; } = "application/json";
        
        /// <summary>
        /// Asynchronously gets the root <see cref="IParseNode"/> of the json to be read.
        /// </summary>
        /// <param name="contentType">The content type of the stream to be parsed</param>
        /// <param name="content">The <see cref="Stream"/> containing json to parse.</param>
        /// <param name="cancellationToken">The cancellation token for the task</param>
        /// <returns>An instance of <see cref="IParseNode"/> for json manipulation</returns>
        public async Task<IParseNode> GetRootParseNodeAsync(string contentType, Stream content, CancellationToken cancellationToken = default)
        {
            if(string.IsNullOrEmpty(contentType))
                throw new ArgumentNullException(nameof(contentType));
            else if(!ValidContentType.Equals(contentType, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentOutOfRangeException($"expected a {ValidContentType} content type");

            _ = content ?? throw new ArgumentNullException(nameof(content));

            using var jsonDocument = await JsonDocument.ParseAsync(content, cancellationToken: cancellationToken).ConfigureAwait(false);
            return new CustomJsonParseNode(jsonDocument.RootElement.Clone(), _jsonJsonSerializationContext);
        }

        /// <summary>
        /// Gets the root <see cref="IParseNode"/> of the json to be read.
        /// </summary>
        /// <param name="contentType">The content type of the stream to be parsed</param>
        /// <param name="content">The <see cref="Stream"/> containing json to parse.</param>
        /// <returns>An instance of <see cref="IParseNode"/> for json manipulation</returns>
        [Obsolete("Use GetRootParseNodeAsync instead")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IParseNode GetRootParseNode(string contentType, Stream content)
        {
            if(string.IsNullOrEmpty(contentType))
                throw new ArgumentNullException(nameof(contentType));
            else if(!ValidContentType.Equals(contentType, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentOutOfRangeException($"expected a {ValidContentType} content type");

            _ = content ?? throw new ArgumentNullException(nameof(content));

            using var jsonDocument = JsonDocument.Parse(content);
            return new CustomJsonParseNode(jsonDocument.RootElement.Clone(), _jsonJsonSerializationContext);
        }
    }
}