using Movies.DataAccess.Data;
using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Movies.DataAccess.Repositories
{
    public class EFGenreRepository : IGenreRepository
    {
        private MoviesDbContext db;

        public EFGenreRepository(MoviesDbContext moviesDbContext)
        {
            db = moviesDbContext;
        }
        public Genre Add(Genre entity)
        {
            db.Genres.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public IList<Genre> GetAll()
        {
            return db.Genres.ToList();
        }

        public Genre GetById(int id)
        {
            return db.Genres.Find(id);
        }

        public IList<Genre> GetWithCriteria(Expression<Func<Genre, bool>> ctiteria)
        {
            throw new NotImplementedException();
        }
    }
}
