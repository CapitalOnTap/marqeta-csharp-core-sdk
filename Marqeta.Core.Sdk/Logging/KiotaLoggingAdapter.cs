using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;

namespace Marqeta.Core.Sdk.Logging;

//This is going to be moved to consumer api, it is not going to stay here
public class KiotaLoggingAdapter : IRequestAdapter
{
    private readonly IRequestAdapter _inner;
    private readonly ILogger<KiotaLoggingAdapter> _logger;

    public KiotaLoggingAdapter(
        IRequestAdapter inner,
        ILogger<KiotaLoggingAdapter> logger)
    {
        _inner = inner;
        _logger = logger;
    }
    
    public ISerializationWriterFactory SerializationWriterFactory 
        => _inner.SerializationWriterFactory;

    public string? BaseUrl
    {
        get => _inner.BaseUrl;
        set => _inner.BaseUrl = value;
    }
    
    public void EnableBackingStore(IBackingStoreFactory backingStoreFactory)
        => _inner.EnableBackingStore(backingStoreFactory);

    public Task<ModelType?> SendAsync<ModelType>(
        RequestInformation requestInfo,
        ParsableFactory<ModelType> factory,
        Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
        CancellationToken cancellationToken = new CancellationToken()) where ModelType : IParsable
        => SendWithLogging(requestInfo,
            () => _inner.SendAsync(requestInfo, factory, errorMapping, cancellationToken));

    public Task<IEnumerable<ModelType>?> SendCollectionAsync<ModelType>(
        RequestInformation requestInfo,
        ParsableFactory<ModelType> factory,
        Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
        CancellationToken cancellationToken = default) where ModelType : IParsable
        => SendWithLogging(requestInfo,
            () => _inner.SendCollectionAsync(requestInfo, factory, errorMapping, cancellationToken));

    public Task<ModelType?> SendPrimitiveAsync<ModelType>(
        RequestInformation requestInfo,
        Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
        CancellationToken cancellationToken = default)
        => SendWithLogging(requestInfo,
            () => _inner.SendPrimitiveAsync<ModelType>(requestInfo, errorMapping, cancellationToken));

    public Task<IEnumerable<ModelType>?> SendPrimitiveCollectionAsync<ModelType>(
        RequestInformation requestInfo,
        Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
        CancellationToken cancellationToken = default)
        => SendWithLogging(requestInfo,
            () => _inner.SendPrimitiveCollectionAsync<ModelType>(requestInfo, errorMapping, cancellationToken));

    public Task SendNoContentAsync(
        RequestInformation requestInfo,
        Dictionary<string, ParsableFactory<IParsable>>? errorMapping = null,
        CancellationToken cancellationToken = default)
        => SendWithLogging<object?>(requestInfo,
            async () =>
            {
                await _inner.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
                return null;
            });  

    public Task<T?> ConvertToNativeRequestAsync<T>(RequestInformation requestInfo,
        CancellationToken cancellationToken = default)
        => _inner.ConvertToNativeRequestAsync<T>(requestInfo, cancellationToken);
    
    private async Task<T?> SendWithLogging<T>(
        RequestInformation requestInfo,
        Func<Task<T?>> send)
    {
        var requestId = Guid.NewGuid();
        using var scope = _logger.BeginScope(new Dictionary<string, object> { ["RequestId"] = requestId });
        
        var uri = requestInfo.URI;
        var method = requestInfo.HttpMethod;

        _logger.LogInformation(
            "[{ReqId}] Sending {Method} {Url} at {Timestamp}",
            requestId, method, uri, DateTimeOffset.UtcNow);
        
        try
        {
            var result = await send().ConfigureAwait(false);

            _logger.LogInformation(
                "[{ReqId}] Completed {Method} {Url} at {Timestamp}",
                requestId, method, uri, DateTimeOffset.UtcNow);
            
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "[{ReqId}] {Method} {Url} failed: {Message}",
                requestId, method, uri, ex.Message);

            throw;
        }
    }
}