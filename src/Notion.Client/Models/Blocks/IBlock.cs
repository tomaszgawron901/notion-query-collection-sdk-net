using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(PageBlock), BlockType.Page)]
    public interface IBlock
    {
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        BlockType Type { get; set; }
    }
}
