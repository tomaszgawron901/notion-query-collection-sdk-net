namespace Notion.Client
{
    public abstract class Reducer : IReducer
    {
        public virtual ReducerType Type { get; set; }
    }
}
