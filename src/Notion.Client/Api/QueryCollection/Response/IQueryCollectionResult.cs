using Newtonsoft.Json;

namespace Notion.Client
{
    public interface IQueryCollectionResult
    {
        [JsonProperty("result")]
        ILoaderResult Result { get; set; }

        [JsonProperty("recordMap")]
        RecordMap RecordMap { get; set; }
    }
}
