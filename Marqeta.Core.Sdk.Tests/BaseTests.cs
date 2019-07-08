using Microsoft.Extensions.Configuration;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public abstract class BaseTests
    {
        protected readonly ITestOutputHelper TestOutputHelper;
        protected static IConfigurationRoot Config = new ConfigurationHelper().GetConfiguration();

        protected static string BaseUrl = Config["Marqeta:BaseUrl"];
        protected static string UserName = Config["Marqeta:UserName"];
        protected static string Password = Config["Marqeta:Password"];

        public BaseTests(ITestOutputHelper testOutputHelper)
        {
            TestOutputHelper = testOutputHelper;
        }

        public static IMarqetaClient GetMarqetaClient()
        {
            return new MarqetaClient(BaseUrl, UserName, Password);
        }
    }
}