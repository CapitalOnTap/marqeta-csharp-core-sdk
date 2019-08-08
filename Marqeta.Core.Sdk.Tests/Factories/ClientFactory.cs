using Microsoft.Extensions.Configuration;

namespace Marqeta.Core.Sdk.Tests.Factories
{
    public static class ClientFactory
    {
        private static readonly IConfigurationRoot Config = new ConfigurationHelper().GetConfiguration();
        private static readonly string BaseUrl = Config["Marqeta:BaseUrl"];
        private static readonly string UserName = Config["Marqeta:UserName"];
        private static readonly string Password = Config["Marqeta:Password"];

        /// <summary>
        /// Get an instance of an IMarqetaClient
        /// </summary>
        /// <returns></returns>
        public static IMarqetaClient GetMarqetaClient()
        {
            return new MarqetaClient(BaseUrl, UserName, Password);
        }
    }
}