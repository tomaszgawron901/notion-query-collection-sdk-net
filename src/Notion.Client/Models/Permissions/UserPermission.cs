using System;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class UserPermission : Permission
    {
        public override PermissionType Type => PermissionType.UserPermission;

        [JsonProperty("user_id")]
        public Guid UserId { get; set; }
    }
}
