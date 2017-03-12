using System.Collections.Generic;
using StatlerWaldorfCorp.EcommerceCatalog.Models;

namespace StatlerWaldorfCorp.EcommerceCatalog.Persistence
{
    public class MemoryProductRepository : IProductRepository
    {
        private List<Product> products;

        public MemoryProductRepository()
        {
            products = new List<Product>();

            products.Add(new Product
            {
                SKU = 123,
                Name = "The Magic 123"
            });

            products.Add(new Product
            {
                SKU = 456,
                Name = "Supervac"
            });
        }
        public ICollection<Product> All()
        {
            return products;
        }
    }
}
