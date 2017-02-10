using System;
using Microsoft.AspNetCore.Mvc;

namespace StatlerWaldorfCorp.EcommerceCatalog.Controllers
{
    [Route("api/products")]    
    public class ProductsController : Controller    
    {
        public ProductsController()
        {
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return this.Ok();
        }        
    }
}