using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Notion.Client
{
    public class PageBlock : Block
    {
        public override BlockType Type => BlockType.Page;

        [JsonProperty("properties")]
        public IDictionary<string, List<List<string>>> Properties { get; set; }

        [JsonProperty("content")]
        public List<Guid> Content { get; set; }

        [JsonProperty("format")]
        public Format Format { get; set; }

        [JsonProperty("permissions")]
        public List<IPermission> Permissions { get; set; }
    }
}
