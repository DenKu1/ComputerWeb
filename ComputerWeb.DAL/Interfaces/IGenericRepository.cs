using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ComputerNet.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, IRequireId
    {
        void Create(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Update(TEntity entityToUpdate);
        void Delete(int id);
    }
}
