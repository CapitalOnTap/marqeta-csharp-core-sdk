using Microsoft.Extensions.Configuration;

namespace Marqeta.Core.Sdk.Tests
{
    public class ConfigurationHelper
    {
        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<ConfigurationHelper>();
            builder.AddEnvironmentVariables();
            return builder.Build();
        }
    }
}
