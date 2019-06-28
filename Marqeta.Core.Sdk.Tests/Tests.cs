using System;
using System.Net.Http;
using System.Text;
using Marqeta.Core.Abstractions;
using Marqeta.Core.Sdk.Helpers;
using Microsoft.Extensions.Configuration;
using Xunit;
using Xunit.Abstractions;

namespace Marqeta.Core.Sdk.Tests
{
    public class Tests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        protected static IConfigurationRoot Config = new ConfigurationHelper().GetConfiguration();
        protected static string BaseUrl = Config["Marqeta:BaseUrl"];
        protected static string UserName = Config["Marqeta:UserName"];
        protected static string Password = Config["Marqeta:Password"];

        public Tests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Deserialise()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(BaseUrl)
            };
            var byteArray = Encoding.ASCII.GetBytes($"{UserName}:{Password}");
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            var client = new MarqetaClient(httpClient);
            var response = client.MccgroupsGetAsync().GetAwaiter().GetResult();
            foreach (var mccGroup in response.Data)
            {
                _testOutputHelper.WriteLine(mccGroup.ToString());
            }
        }

        [Fact]
        public void Deserialise1()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(BaseUrl)
            };
            var byteArray = Encoding.ASCII.GetBytes($"{UserName}:{Password}");
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            var client = new MarqetaClient(httpClient);
            var response = client.MccgroupsGetAsync(sort_by: "-createdTime", start_index: 2, count: 20).GetAwaiter().GetResult();
            foreach (var mccGroup in response.Data)
            {
                _testOutputHelper.WriteLine(mccGroup.ToString());
            }
        }

        [Fact]
        public void UpdateAllAuthorizationControls()
        {
            var client = new MarqetaClient(BaseUrl, UserName, Password);
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