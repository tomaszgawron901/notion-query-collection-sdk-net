using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class Format
    {
        [JsonProperty("collection_page_properties")]
        public List<FormatValue> CollectionPageProperties { get; set; }
    }
}
