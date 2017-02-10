using System;
using Microsoft.AspNetCore.Mvc;
using StatlerWaldorfCorp.EcommerceCatalog.Persistence;

namespace StatlerWaldorfCorp.EcommerceCatalog.Controllers
{
    [Route("api/products")]    
    public class ProductsController : Controller    
    {
        private IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return this.Ok(this.productRepository.All());
        }
    }
}