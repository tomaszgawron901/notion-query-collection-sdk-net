using System.Threading.Tasks;
using System.Collections.Generic;

namespace Notion.Client
{
    public class NotionClient : INotionClient
    {
        private readonly IRestClient _restClient;

        public NotionClient(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<QueryCollectionResult> QueryCollectionAsync(QueryCollectionRequestBody collectionQueryParameters)
        {
            var body = (IQueryCollectionRequestBody)collectionQueryParameters;
            var queryParams = new Dictionary<string, string>
            {
                {"src", "reset"}
            };

            return await _restClient.PostAsync<QueryCollectionResult>(ApiEndpoints.QueryCollection(), body, queryParams);
        }
    }
}
