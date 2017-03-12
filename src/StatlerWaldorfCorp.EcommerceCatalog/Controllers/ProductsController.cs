using System;
using Microsoft.AspNetCore.Mvc;
using StatlerWaldorfCorp.EcommerceCatalog.InventoryClient;
using StatlerWaldorfCorp.EcommerceCatalog.Persistence;

namespace StatlerWaldorfCorp.EcommerceCatalog.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {
        private IProductRepository productRepository;
        private IInventoryClient inventoryClient;

        public ProductsController(IProductRepository productRepository, IInventoryClient inventoryClient)
        {
            this.productRepository = productRepository;
            this.inventoryClient = inventoryClient;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return this.Ok(this.productRepository.All());
        }

        [HttpGet("{sku}")]
        public IActionResult GetProduct(int sku)
        {
            var product = new
            {
                Product = this.productRepository.Get(sku),
                Status = this.inventoryClient.GetStockStatusAsync(sku).Result
            };
            return this.Ok(product);
        }
    }
}