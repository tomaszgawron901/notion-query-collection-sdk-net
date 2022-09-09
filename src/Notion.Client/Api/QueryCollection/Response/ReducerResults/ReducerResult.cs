namespace Notion.Client
{
    public abstract class ReducerResult : IReducerResult
    {
        public virtual ReducerType Type { get; set; }
    }
}

