namespace Notion.Client
{
    public static class NotionClientFactory
    {
        public static NotionClient Create(ClientOptions options)
        {
            var restClient = new RestClient(options);

            return new NotionClient(
                restClient: restClient
            );
        }
    }
}
