using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ComputerNet.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

        TEntity GetById(int id);

        void Update(TEntity entityToUpdate);

        void Delete(int id);

        void Delete(TEntity entityToDelete);
    }
}
