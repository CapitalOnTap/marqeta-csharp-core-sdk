using System;
using Marqeta.Core.Sdk.Services;
using RestSharp;
using RestSharp.Authenticators;

namespace Marqeta.Core.Sdk
{
    public class MarqetaClient
    {
        internal IRestClient RestClient;

        public MccGroupService MccGroups { get; private set; }

        public MarqetaClient(string baseUrl, string userName, string password)
        {
            RestClient = new RestClient
            {
                BaseUrl = new Uri(baseUrl),
                Authenticator = new HttpBasicAuthenticator(userName, password)
            };

            MccGroups = new MccGroupService(this);
        }
    }
}
