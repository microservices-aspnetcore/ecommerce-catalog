using StatlerWaldorfCorp.EcommerceCatalog.Models;
using Steeltoe.Discovery.Client;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace StatlerWaldorfCorp.EcommerceCatalog.InventoryClient
{
    public class HttpInventoryClient : IInventoryClient
    {
        private DiscoveryHttpClientHandler handler;
        private const string STOCKSERVICE_URL_BASE = "http://inventory/api/skustatus/";

        public HttpInventoryClient(IDiscoveryClient client)
        {
            this.handler = new DiscoveryHttpClientHandler(client);
        }


        private HttpClient CreateHttpClient()
        {
            return new HttpClient(this.handler, false);
        }

        public async Task<StockStatus> GetStockStatusAsync(int sku)
        {
            StockStatus stockStatus = null;

            using (HttpClient client = this.CreateHttpClient())
            {
                var result = await client.GetStringAsync(STOCKSERVICE_URL_BASE + sku.ToString());
                stockStatus = JsonConvert.DeserializeObject<StockStatus>(result);
            }

            return stockStatus;
        }
    }
}
