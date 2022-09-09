using Newtonsoft.Json;

namespace Notion.Client
{
    public class FormatValue
    {
        [JsonProperty("visibility")]
        public bool Visibility { get; set; }

        [JsonProperty("property")]
        public string Property { get; set; }
    }
}
