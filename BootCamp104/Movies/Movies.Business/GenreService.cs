using Movies.Business.DataTransferObjects;
using Movies.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movies.Business
{
    public class GenreService : IGenreService
    {
        private IGenreRepository genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }
        public IList<GenreResponseList> GetAllGenres()
        {
            var dtoList = genreRepository.GetAll().ToList();
            List<GenreResponseList> result = new List<GenreResponseList>();
            dtoList.ForEach(g => result.Add(new GenreResponseList
            {
                Id = g.Id,
                Name = g.Name
            }));

            return result;
        }
    }
}
