using Nest;

namespace Elasticsearch_app.Services
{
    public interface IIndicesService
    {
        Task<GetIndexResponse> GetAllAsync()
;    }
}