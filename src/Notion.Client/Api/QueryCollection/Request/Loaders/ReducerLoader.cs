using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Notion.Client
{
    public class ReducerLoader : Loader
    {
        public override LoaderType Type => LoaderType.Reducer;

        [JsonProperty("reducers")]
        public IDictionary<string, IReducer> Reducers { get; set; }

        [JsonProperty("sort")]
        public object[] Sort => Array.Empty<object>();

        [JsonProperty("searchQuery")]
        public string SearchQuery => string.Empty;

        [JsonProperty("userTimeZone")]
        public string TimeZone => string.Empty;
    }
}


