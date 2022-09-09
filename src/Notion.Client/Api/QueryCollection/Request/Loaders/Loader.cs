
namespace Notion.Client
{
    public abstract class Loader : ILoader
    {
        public virtual LoaderType Type { get; set; }
    }
}
