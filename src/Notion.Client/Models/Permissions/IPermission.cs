using JsonSubTypes;
using Newtonsoft.Json;

namespace Notion.Client
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(UserPermission), PermissionType.UserPermission)]
    [JsonSubtypes.KnownSubType(typeof(PublicPermission), PermissionType.PublicPermission)]
    public interface IPermission
    {
        PermissionType Type { get; set; }
    }
}
