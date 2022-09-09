using System;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ObjectIdentifier
    {
        [JsonProperty("id")]
        public Guid id { get; set; }

        [JsonProperty("spaceId")]
        public Guid SpaceId { get; set; }
    }
}
