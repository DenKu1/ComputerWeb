using AutoMapper;
using ComputerNet.BLL.Interfaces;
using ComputerNet.DAL.Interfaces;
using System.Collections.Generic;

namespace ComputerNet.BLL.Services
{
    public class GenericService<TEntity, TEntityDTO> : IGenericService<TEntityDTO>
        where TEntity : class
        where TEntityDTO : class
    {
        protected readonly IMapper _mp;
        protected readonly IUnitOfWork _db;
        protected readonly IGenericRepository<TEntity> _repo;

        public GenericService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _db = unitOfWork;
            _mp = mapper;
            _repo = unitOfWork.Set<TEntity>();
        }

        public virtual void Create(TEntityDTO itemDTO)
        {
            if (itemDTO == null)
            {
                return;
            }

            TEntity item = _mp.Map<TEntity>(itemDTO);

            _repo.Create(item);
            _db.Save();
        }

        public virtual void Delete(int id)
        {
            _repo.Delete(id);
            _db.Save();
        }

        public virtual IEnumerable<TEntityDTO> GetAll()
        {
            IEnumerable<TEntity> items = _repo.Get();

            return _mp.Map<IEnumerable<TEntityDTO>>(items);
        }

        public virtual TEntityDTO GetById(int id)
        {
            TEntity item = _repo.GetById(id);

            return _mp.Map<TEntityDTO>(item);
        }

        public virtual void Update(TEntityDTO itemToUpdateDTO)
        {
            if (itemToUpdateDTO == null)
            {
                return;
            }
           
            TEntity itemToUpdate = _mp.Map<TEntity>(itemToUpdateDTO);

            _repo.Update(itemToUpdate);
            _db.Save();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
