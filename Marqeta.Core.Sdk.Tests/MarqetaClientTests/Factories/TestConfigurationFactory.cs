using Microsoft.Extensions.Configuration;

namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories
{
    internal static class TestConfigurationFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IConfigurationRoot"/> for tests.
        /// </summary>
        /// <returns>The created <see cref="IConfigurationRoot"/> instance.</returns>
        public static IConfigurationRoot Create() =>
            new ConfigurationBuilder()
                .AddUserSecrets<BaseTests>()
                .AddEnvironmentVariables()
                .Build();
    }
}