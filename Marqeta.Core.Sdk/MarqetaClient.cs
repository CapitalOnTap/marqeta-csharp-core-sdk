using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Marqeta.Core.Sdk
{
    public partial class MarqetaClient
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MarqetaClient"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL of the Marqeta environment.</param>
        /// <param name="username">The username of the Marqeta environment.</param>
        /// <param name="password">The password of the Marqeta environment.</param>
        public MarqetaClient(string baseUrl, string username, string password)
            : this(baseUrl, CreateHttpClient(baseUrl, username, password))
        {
        }

        /// <summary>
        ///     Creates new instance of <see cref="HttpClient"/> with a default
        ///     <c>Authorization</c> header constructed from the provided credentials.
        /// </summary>
        protected static HttpClient CreateHttpClient(string baseUrl, string username, string password)
        {
            var httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };

            var bytes = Encoding.ASCII.GetBytes($"{username}:{password}");
            var base64 = Convert.ToBase64String(bytes);

            httpClient.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue("Basic", base64);

            return httpClient;
        }
    }
}
