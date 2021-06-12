using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Business;
using Movies.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {

        private IGenreService service;
        public GenresController(IGenreService genreService)
        {
            service = genreService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllGenres();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var genreListReponse = service.GetGenresById(id);
            if (genreListReponse != null)
            {
                return Ok(genreListReponse);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddGenre(AddNewGenreRequest request)
        {
            if (ModelState.IsValid)
            {
                int genreId = service.AddGenre(request);
                return CreatedAtAction(nameof(GetById), routeValues: new { id = genreId }, value: null);
            }

            return BadRequest(ModelState);



        }


    }
}
