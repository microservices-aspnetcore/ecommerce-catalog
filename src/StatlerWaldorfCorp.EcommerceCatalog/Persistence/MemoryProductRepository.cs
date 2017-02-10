using System.Collections.Generic;
using StatlerWaldorfCorp.EcommerceCatalog.Models;

namespace StatlerWaldorfCorp.EcommerceCatalog.Persistence
{
    public class MemoryProductRepository : IProductRepository
    {
        public ICollection<Product> All()
        {
            return new List<Product>();
        }
    }
}
