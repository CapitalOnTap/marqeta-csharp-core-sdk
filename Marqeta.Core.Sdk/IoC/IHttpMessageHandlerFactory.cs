namespace Marqeta.Core.Sdk.IoC;

public interface IHttpMessageHandlerFactory
{
    HttpMessageHandler GetHttpMessageHandler();
}