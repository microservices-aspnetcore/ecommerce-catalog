using System.Collections.Generic;
using StatlerWaldorfCorp.EcommerceCatalog.Models;

namespace StatlerWaldorfCorp.EcommerceCatalog.Persistence
{
    public interface IProductRepository
    {
        ICollection<Product> All();
        Product Get(int sku);
    }
}