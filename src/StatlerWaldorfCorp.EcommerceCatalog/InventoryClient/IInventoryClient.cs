using StatlerWaldorfCorp.EcommerceCatalog.Models;

namespace StatlerWaldorfCorp.EcommerceCatalog.InventoryClient
{
    public interface IInventoryClient
    {
        StockStatus GetStockStatus(int sku);
    }
}