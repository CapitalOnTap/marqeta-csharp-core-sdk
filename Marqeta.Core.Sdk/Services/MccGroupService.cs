using Marqeta.Core.Sdk.Responses;
using RestSharp;

namespace Marqeta.Core.Sdk.Services
{
    public class MccGroupService
    {
        protected readonly MarqetaClient MarqetaClient;

        public MccGroupService(MarqetaClient marqetaClient)
        {
            MarqetaClient = marqetaClient;
        }

        public object[] List()
        {
            var request = new RestRequest("mccgroups");
            var response = MarqetaClient.RestClient.Execute(request);
            return null;
        }
    }
}