namespace Marqeta.Core.Sdk.Tests.MarqetaClientTests.Factories
{
    internal static class TestMarqetaClientFactory
    {
        /// <summary>
        ///     Create a new instance of <see cref="IMarqetaClient"/> for tests.
        /// </summary>
        /// <returns>The created <see cref="IMarqetaClient"/> instance.</returns>
        public static IMarqetaClient Create()
        {
            var config = TestConfigurationFactory.Create();

            return new MarqetaClient(
                config["Marqeta:BaseUrl"],
                config["Marqeta:UserName"],
                config["Marqeta:Password"])
            {
                ReadResponseAsString = true,
            };
        }
    }
}