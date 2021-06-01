using IntroWebAPI.Business;
using IntroWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace IntroWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //Buraya request gelecek
        //GET - POST
        [HttpGet]
        public IActionResult AllProducts()
        {

            //Ctrl + K + D
            //List<string> words = new List<string>();
            //words.Add()

            ProductService dataService = new ProductService();
            var list = dataService.GetListResponseDTOs();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            ProductService dataService = new ProductService();
            var product = dataService.GetProductResponseDto(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            //varsayın ki db'ye ekledik...
            return CreatedAtAction(nameof(GetProductById), new { id = 3 }, null);

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Product product)
        {
            //farzedin ki güncelleme yaptı....
            return Ok();
        }
    }
}
