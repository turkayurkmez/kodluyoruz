using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Movies.DataAccess.Repositories
{
    public class FakeGenreRepository : IGenreRepository
    {
        public Genre Add(Genre entity)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetAll()
        {
            return new List<Genre>
           {
               new Genre{ Id =1, Name="Bilim-Kurgu"},
               new Genre{ Id =2, Name="Aksiyon"},
               new Genre{ Id =3, Name="Korku"},
               new Genre{ Id =4, Name="Komedi"},
           };
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetWithCriteria(Expression<Func<Genre, bool>> ctiteria)
        {
            throw new NotImplementedException();
        }
    }
}
