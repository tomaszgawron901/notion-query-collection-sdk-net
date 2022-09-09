using System.Runtime.Serialization;

namespace Notion.Client
{
    public enum BlockType
    {
        [EnumMember(Value = "page")]
        Page,

        [EnumMember(Value = "unsupported")]
        Unsupported
    }
}
