using Newtonsoft.Json;

namespace Notion.Client
{
    public class QueryCollectionRequestBody : IQueryCollectionRequestBody
    {
        public ObjectIdentifier Collection { get; set; }
        public ObjectIdentifier CollectionView { get; set; }
        public ILoader Loader { get; set; }
    }
}
