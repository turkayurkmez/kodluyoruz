using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Movies.Models;

namespace Movies.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : IEntity, new()
    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        IList<TEntity> GetWithCriteria(Expression<Func<TEntity, bool>> ctiteria);
        TEntity Add(TEntity entity);
        TEntity Update(Genre genre);
        void Delete(int id);
        void Delete(TEntity entity);
    }

}
