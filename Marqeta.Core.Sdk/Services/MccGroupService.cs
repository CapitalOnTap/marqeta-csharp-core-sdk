using Marqeta.Core.Abstractions.MccGroups;
using Marqeta.Core.Sdk.Responses;
using Newtonsoft.Json;
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

        public PaginatedResponse<MccGroup> List()
        {
            var request = new RestRequest("mccgroups");
            var response = MarqetaClient.RestClient.Execute(request);
            return JsonConvert.DeserializeObject<PaginatedResponse<MccGroup>>(response.Content);
        }
    }
}