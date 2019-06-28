using System;
using System.Net.Http;
using System.Text;

namespace Marqeta.Core.Sdk
{
    public partial class MarqetaClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarqetaClient"/> class.
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public MarqetaClient(string baseUrl, string userName, string password)
        : this(CreateHttpClient(baseUrl,userName,password))
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        protected static HttpClient CreateHttpClient(string baseUrl, string userName, string password)
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
            var byteArray = Encoding.ASCII.GetBytes($"{userName}:{password}");
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            return httpClient;
        }
    }
}
