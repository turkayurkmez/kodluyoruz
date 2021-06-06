using Movies.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Business
{
   public interface IGenreService
    {
        IList<GenreResponseList> GetAllGenres();
    }
}
