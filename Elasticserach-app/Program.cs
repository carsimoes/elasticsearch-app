using Elasticsearch_app.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Elasticsearch_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHost();

            IndicesService inventoryService = ActivatorUtilities.CreateInstance<IndicesService>(host.Services);
            var result = inventoryService.GetAllAsync().Result ;
        }

        private static IHost CreateHost()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddSingleton<IIndicesService, IndicesService>();
            })
            .Build();
        }
    }
}



