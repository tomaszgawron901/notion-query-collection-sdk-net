using JsonSubTypes;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(ReducerLoaderResult), LoaderType.Reducer)]
    public interface ILoaderResult
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        LoaderType Type { get; set; }
    }
}
