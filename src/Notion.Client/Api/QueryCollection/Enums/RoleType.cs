using System.Runtime.Serialization;

namespace Notion.Client
{
    public enum RoleType
    {
        [EnumMember(Value = "none")]
        None = default,

        [EnumMember(Value = "reader")]
        Reader,

        [EnumMember(Value = "writer")]
        Writer,

        [EnumMember(Value = "owner")]
        Owner,
    }
}
