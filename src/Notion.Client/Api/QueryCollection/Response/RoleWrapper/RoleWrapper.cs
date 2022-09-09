using Newtonsoft.Json;

namespace Notion.Client
{
    public class RoleWrapper
    {
        [JsonProperty("role")]
        public RoleType Role { get; set; }
    }
}
