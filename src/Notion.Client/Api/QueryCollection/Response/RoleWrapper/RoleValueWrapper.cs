using Newtonsoft.Json;

namespace Notion.Client
{
    public class RoleValueWrapper<T> : RoleWrapper
    {
        [JsonProperty("value")]
        T Value { get; set; }
    }
}
