namespace Notion.Client
{
    public abstract class LoaderResult : ILoaderResult
    {
        public virtual LoaderType Type { get; set; }
    }
}
