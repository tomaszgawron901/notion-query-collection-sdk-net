using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class Collection : ResponseObject
    {
        [JsonProperty("name")]
        public List<List<string>> Name { get; set; }

        [JsonProperty("format")]
        public Format Format { get; set; }

        [JsonProperty("schema")]
        public IDictionary<string, Property> Schema { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("template_pages")]
        public List<string> TemplatePages { get; set; }

        public bool Migrated { get; set; }
    }
}
