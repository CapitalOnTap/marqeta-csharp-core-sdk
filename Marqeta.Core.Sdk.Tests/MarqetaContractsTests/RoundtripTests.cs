using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoFixture.Kernel;
using DeepEqual.Syntax;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests.MarqetaContractsTests
{
    public class RoundtripTests : BaseTests
    {
        private readonly ITestOutputHelper _output;

        public RoundtripTests(ITestOutputHelper output) =>
            _output = output;

        [Fact]
        public void Roundtrip_all_classes()
        {
            var types = GetDtoTypes().ToArray();

            // We catch all the exceptions and output exception messages rather than
            // just allowing execution to simply end. This provides us with more
            // helpful output at the CI/CD level.
            var exceptions = new ConcurrentDictionary<Type, Exception>();

            Parallel.ForEach(types, type =>
            {
                try
                {
                    var fixture = GetFixture();
                    var original = fixture.Create(type, new SpecimenContext(fixture));

                    var json = JsonConvert.SerializeObject(original);
                    var deserialized = JsonConvert.DeserializeObject(json, type);

                    original.ShouldDeepEqual(deserialized);
                }
                catch (Exception exception)
                {
                    exceptions.TryAdd(type, exception);
                }
            });

            foreach (var kvp in exceptions)
            {
                _output.WriteLine($"Error when testing type '{kvp.Key.FullName}'.");

                var exception = kvp.Value;
                do
                {
                    _output.WriteLine(exception.Message);
                    exception = exception.InnerException;
                }
                while (exception != null);
            }

            Assert.Empty(exceptions);
        }

        /// <summary>
        ///     Returns all DTO types marked with <c>[GeneratedCode("NJsonSchema")]</c>.
        /// </summary>
        private static IEnumerable<Type> GetDtoTypes() =>
            typeof(MarqetaClient).Assembly
                .GetTypes()
                .Where(x => x.GetCustomAttribute<GeneratedCodeAttribute>() is { Tool: "NJsonSchema" });
    }
}