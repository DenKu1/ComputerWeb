using ComputerNet.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ComputerNet.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IRequireId
    {
        private readonly List<TEntity> _set;

        public GenericRepository()
        {
            _set = Container.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            _set.Add(entity);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _set;
        }

        public void Delete(int id)
        {
           TEntity entity = _set.Where(e => e.Id == id).FirstOrDefault();
            if (entity != null)
            {
                _set.Remove(entity);
            }
        }

        public TEntity GetById(int id)
        {
            return _set.Where(e => e.Id == id).FirstOrDefault();
        }

        public void Update(TEntity entityToUpdate)
        {            
            var entity = _set.Where(e => e.Id == entityToUpdate.Id).FirstOrDefault();

            if (entity != null)
            {
                int index = _set.IndexOf(entity);

                _set[index] = entityToUpdate;     
            }
            
        }
    }
}
