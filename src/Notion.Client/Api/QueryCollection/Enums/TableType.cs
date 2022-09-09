using System.Runtime.Serialization;

namespace Notion.Client
{
    public enum TableType
    {
        [EnumMember(Value = "collection")]
        Collection,

        [EnumMember(Value = "block")]
        Block,

        [EnumMember(Value = "space")]
        Space,

        [EnumMember(Value = "notion_user")]
        NotionUser
    }
}
