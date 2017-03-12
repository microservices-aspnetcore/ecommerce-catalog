using System.Collections.Generic;
using StatlerWaldorfCorp.EcommerceCatalog.Models;

namespace StatlerWaldorfCorp.EcommerceCatalog.Persistence
{
    public class MemoryProductRepository : IProductRepository
    {
        private Dictionary<int, Product> products;

        public MemoryProductRepository()
        {
            products = new Dictionary<int, Product>();

            products.Add(123, new Product
            {
                SKU = 123,
                Name = "The Magic 123"
            });

            products.Add(456, new Product
            {
                SKU = 456,
                Name = "Supervac"
            });
        }
        public ICollection<Product> All()
        {
            return products.Values;
        }

        public Product Get(int sku)
        {
            return products[sku];
        }
    }
}
