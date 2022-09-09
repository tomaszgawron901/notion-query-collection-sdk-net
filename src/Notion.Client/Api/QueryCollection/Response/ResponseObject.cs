using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    public abstract class ResponseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("parent_table")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TableType ParentTable { get; set; }

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("space_id")]
        public string SpaceId { get; set; }
    }
}
