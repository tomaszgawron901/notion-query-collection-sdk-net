using Newtonsoft.Json;

namespace Notion.Client
{
    public class ResultReducer : Reducer
    {
        public override ReducerType Type => ReducerType.Results;

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
