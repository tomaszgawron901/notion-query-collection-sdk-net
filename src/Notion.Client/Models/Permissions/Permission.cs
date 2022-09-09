using Newtonsoft.Json;

namespace Notion.Client
{
    public class Permission : IPermission
    {
        public virtual PermissionType Type { get; set; }

        [JsonProperty("role")]
        public RoleType Role { get; set; }
    }
}
