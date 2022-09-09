using Newtonsoft.Json;

namespace Notion.Client
{
    public class PublicPermission : Permission
    {
        public override PermissionType Type => PermissionType.PublicPermission;

        [JsonProperty("added_timestamp")]
        public long AddedTimestamp { get; set; }
    }
}
