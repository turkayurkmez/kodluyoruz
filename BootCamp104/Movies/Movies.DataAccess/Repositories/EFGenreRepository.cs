using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Movies.DataAccess.Repositories
{
    public class EFGenreRepository : IGenreRepository
    {
        public Genre Add(Genre entity)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetAll()
        {
            throw new NotImplementedException();
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
