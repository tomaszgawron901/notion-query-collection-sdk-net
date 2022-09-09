using JsonSubTypes;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ResultsReducerResult), ReducerType.Results)]
    public interface IReducerResult
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        ReducerType Type { get; set; }
    }
}
