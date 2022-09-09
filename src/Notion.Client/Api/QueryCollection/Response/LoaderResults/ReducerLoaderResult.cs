using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class ReducerLoaderResult : LoaderResult
    {
        public override LoaderType Type => LoaderType.Reducer;

        [JsonProperty("reducerResults")]
        public IDictionary<string, IReducerResult> Results { get; set; }

        [JsonProperty("sizeHint")]
        public int SizeHint { get; set; }
    }
}
