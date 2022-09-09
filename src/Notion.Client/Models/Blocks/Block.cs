using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Notion.Client
{
    public abstract class Block : ResponseObject, IBlock
    {
        public virtual BlockType Type { get; set; }

        [JsonProperty("created_time")]
        public long CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public long LastEditedTime { get; set; }

        [JsonProperty("created_by_table")]
        public TableType CreatedByTable { get; set; }

        [JsonProperty("created_by_id")]
        public string CreatedById { get; set; }

        [JsonProperty("last_edited_by_table")]
        public TableType LastEditedByTable { get; set; }

        [JsonProperty("last_edited_by_id")]
        public string LastEditedById { get; set; }
    }
}
