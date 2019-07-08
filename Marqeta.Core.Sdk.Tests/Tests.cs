using System;
using System.Net.Http;
using System.Text;
using Marqeta.Core.Abstractions;
using Marqeta.Core.Sdk.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public class Tests : BaseTests
    {
        public Tests(ITestOutputHelper testOutputHelper) : base (testOutputHelper)
        {
        }

        [Fact]
        public void Deserialise()
        {
            var client = GetMarqetaClient();
            var response = client.MccgroupsGetAsync().GetAwaiter().GetResult();
            foreach (var mccGroup in response.Data)
            {
                TestOutputHelper.WriteLine(mccGroup.ToString());
            }
        }

        [Fact]
        public void Deserialise1()
        {
            var client = GetMarqetaClient();
            var response = client.MccgroupsGetAsync(sort_by: "-createdTime", start_index: 2, count: 20).GetAwaiter().GetResult();
            foreach (var mccGroup in response.Data)
            {
                TestOutputHelper.WriteLine(mccGroup.ToString());
            }
        }

        [Fact]
        public void UpdateAllAuthorizationControls()
        {
            var client = GetMarqetaClient();
            var response = client.AuthcontrolsGetAsync().Result;

            foreach (var authControl in response.Data)
            {
                var originalName = authControl.Name;
                var newName = $"{originalName}.Test";

                DtoConverter.Convert(authControl, out Auth_control_update_request body);
                body.Name = newName;

                var response1 = client.AuthcontrolsPutAsync(authControl.Token, body).Result;
                Assert.Equal(response1.Name, newName);

                body.Name = originalName;
                var response2 = client.AuthcontrolsPutAsync(authControl.Token, body).Result;
                Assert.Equal(response2.Name, originalName);
            }
        }
    }
}