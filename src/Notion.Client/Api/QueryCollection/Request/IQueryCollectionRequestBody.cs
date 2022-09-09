using Newtonsoft.Json;

namespace Notion.Client
{
    public interface IQueryCollectionRequestBody
    {
        [JsonProperty("collection")]
        ObjectIdentifier Collection { get; set; }

        [JsonProperty("collectionView")]
        ObjectIdentifier CollectionView { get; set; }

        [JsonProperty("loader")]
        ILoader Loader { get; set; }
    }
}
