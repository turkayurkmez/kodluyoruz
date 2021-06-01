using DIDemoinAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoinAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService service;
        public ProductsController(IProductService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var products = service.GetProducts();
            return Ok(products);
        }
    }
}
