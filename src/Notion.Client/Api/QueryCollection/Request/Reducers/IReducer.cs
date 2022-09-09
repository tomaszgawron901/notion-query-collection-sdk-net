using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ResultReducer), ReducerType.Results)]
    public interface IReducer
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        ReducerType Type { get; set; }
    }
}
