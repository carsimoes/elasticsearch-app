using Nest;

namespace Elasticsearch_app.Services
{
    public class IndicesService : IIndicesService
    {
        public async Task<GetIndexResponse> GetAllAsync()
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9200"));
            var _elasticClient = new ElasticClient(settings);

            var result = await _elasticClient.Indices.GetAsync(new GetIndexRequest(Indices.All));

            return result;
            
        }
    }
}
