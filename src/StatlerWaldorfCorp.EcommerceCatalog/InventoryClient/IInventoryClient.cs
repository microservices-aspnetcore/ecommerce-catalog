using StatlerWaldorfCorp.EcommerceCatalog.Models;
using System.Threading.Tasks;

namespace StatlerWaldorfCorp.EcommerceCatalog.InventoryClient
{
    public interface IInventoryClient
    {
        Task<StockStatus> GetStockStatusAsync(int sku);
    }
}