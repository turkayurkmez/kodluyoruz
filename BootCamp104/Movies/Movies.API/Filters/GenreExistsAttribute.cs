using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Movies.Business;
using Movies.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Filters
{
    public class GenreExistsAttribute : TypeFilterAttribute
    {
        public GenreExistsAttribute():base(typeof(GenreExistingFilter))
        {

        }

        private class GenreExistingFilter : IAsyncActionFilter
        {
            private IGenreService genreService;
            public GenreExistingFilter(IGenreService genreService)
            {
                this.genreService = genreService;
            }
            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                if (!context.ActionArguments.ContainsKey("id"))
                {
                    context.Result = new BadRequestResult();
                    return;
                }

                if (!(context.ActionArguments["id"] is int id))
                {
                    context.Result = new BadRequestResult();
                    return;
                }

                var genre = genreService.GetGenresById(id);
                if (genre == null)
                {
                    context.Result = new NotFoundObjectResult(new { Message=$"{id} nolu tür bulunamadı "});
                    return;
                }

                await next();
              
            }
        }
    }
}
