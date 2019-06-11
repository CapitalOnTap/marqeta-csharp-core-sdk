using Newtonsoft.Json;

namespace Marqeta.Core.Sdk.Responses
{
    internal abstract class FilteringPaginationBaseResponse<T>
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        [JsonProperty("end_index")]
        public int EndIndex { get; set; }

        [JsonProperty("is_more")]
        public bool IsMore{ get; set; }

        [JsonProperty("data")]
        public T[] Data { get; set; }
    }
}
