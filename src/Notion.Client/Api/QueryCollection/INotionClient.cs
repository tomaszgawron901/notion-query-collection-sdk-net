using System.Threading.Tasks;

namespace Notion.Client
{
    public interface INotionClient
    {
        Task<QueryCollectionResult> QueryCollectionAsync(QueryCollectionRequestBody collectionQueryParameters);
    }
}
