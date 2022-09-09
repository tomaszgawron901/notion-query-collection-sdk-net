using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ResultsReducerResult : ReducerResult
    {
        public override ReducerType Type => ReducerType.Results;

        [JsonProperty("blockIds")]
        public List<int> BlockIds { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }
}
