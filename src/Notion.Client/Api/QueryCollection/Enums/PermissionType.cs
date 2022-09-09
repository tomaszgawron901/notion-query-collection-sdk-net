using System.Runtime.Serialization;

namespace Notion.Client
{
    public enum PermissionType
    {
        [EnumMember(Value = "user_permission")]
        UserPermission,

        [EnumMember(Value = "public_permission")]
        PublicPermission
    }
}
