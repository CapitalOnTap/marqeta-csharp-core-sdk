using Microsoft.Extensions.Configuration;
using Xunit;

namespace Marqeta.Core.Sdk.Tests.MccGroups
{
    public class MccGroupTests
    {
        protected static IConfigurationRoot Config = new ConfigurationHelper().GetConfiguration();
        protected static string BaseUrl = Config["Marqeta:BaseUrl"];
        protected static string UserName = Config["Marqeta:UserName"];
        protected static string Password = Config["Marqeta:Password"];
        
        [Fact]
        public void Deserialise()
        {
            var client = new MarqetaClient(BaseUrl, UserName, Password);
            var response = client.MccGroups.List();
        }
    }
}