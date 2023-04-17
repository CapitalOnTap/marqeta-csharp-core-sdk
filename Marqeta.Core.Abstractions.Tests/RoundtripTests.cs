using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.DataAnnotations;
using AutoFixture.Kernel;
using DeepEqual.Syntax;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Abstractions.Tests
{
    public class RoundtripTests : BaseTests
    {
        public RoundtripTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        [Fact]
        public void Roundtrip_all_classes()
        {

            var assembly = Assembly.Load("Marqeta.Core.Abstractions");
            var classTypes = assembly.GetTypes().Where(x => x.IsClass).ToArray();

            // NB: We catch all the exceptions and output exception messages rather than just allowing execution to simply end.
            //      This provides us with more helpful output at the CI/CD level.
            var exceptions = new ConcurrentDictionary<Type, Exception>();

            Parallel.ForEach(classTypes, type =>
            {
                try
                {
                    var fixture = GetFixture();
                    var original = fixture.Create(type, new SpecimenContext(fixture));
                    var json = JsonConvert.SerializeObject(original);
                    var secondInstance = JsonConvert.DeserializeObject(json, type);
                    original.ShouldDeepEqual(secondInstance);
                }
                catch (Exception exception)
                {
                    exceptions.TryAdd(type, exception);
                }
            });

            // Output
            foreach (var kvp in exceptions)
            {
                TestOutputHelper.WriteLine($"Error when testing type '{kvp.Key.FullName}'.");
                var exception = kvp.Value;
                do
                {
                    TestOutputHelper.WriteLine(exception.Message);
                    exception = exception.InnerException;
                } while (exception != null);
            }

            // Assert
            Assert.Empty(exceptions);
        }
    }
}