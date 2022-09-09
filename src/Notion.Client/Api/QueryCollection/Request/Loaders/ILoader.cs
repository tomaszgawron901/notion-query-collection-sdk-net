using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ReducerLoader), LoaderType.Reducer)]
    public interface ILoader
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        LoaderType Type { get; set; }
    }
}
