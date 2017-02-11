using StatlerWaldorfCorp.EcommerceCatalog.Models;
using Steeltoe.Discovery.Client;

namespace StatlerWaldorfCorp.EcommerceCatalog.InventoryClient
{
    public class HttpInventoryClient : IInventoryClient
    {
        private DiscoveryHttpClientHandler handler;
        private const string GRAB_SERVICE_URL_BASE = "http://stockservice/api/skustatus";

        public HttpInventoryClient(IDiscoveryClient client)
        {
            this.handler = new DiscoveryHttpClientHandler(client);
        }

        public StockStatus GetStockStatus(int sku)
        {
            return null;
        }
    }
}
