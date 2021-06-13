using Movies.Business.DataTransferObjects;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Business
{
   public interface IGenreService
    {
        IList<GenreListResponse> GetAllGenres();
        //eklenen son varlığın id'si:
        int AddGenre(AddNewGenreRequest request);
        GenreListResponse GetGenresById(int id);
        int UpdateGenre(EditGenreRequest request);
        void DeleteGenre(int id);
    }
}
