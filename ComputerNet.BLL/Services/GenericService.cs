using AutoMapper;
using ComputerNet.BLL.Interfaces;
using ComputerNet.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerNet.BLL.Services
{
    public class GenericService<TEntity, TEntityDTO> : IGenericService<TEntityDTO>
        where TEntity : class, IRequireId
        where TEntityDTO : class, IRequireId
    {
        protected readonly IMapper _mp;
        protected readonly IGenericRepository<TEntity> _repo;

        public GenericService(IGenericRepository<TEntity> repository, IMapper mapper)
        {
            _repo = repository;
            _mp = mapper;
        }

        public virtual void Create(TEntityDTO itemDTO)
        {
            if (itemDTO == null)
            {
                return;
            }

            TEntity item = _mp.Map<TEntity>(itemDTO);

            _repo.Create(item);           
        }

        public virtual void Delete(int id)
        {
            _repo.Delete(id);
        }

        public virtual IEnumerable<TEntityDTO> GetAll()
        {
            IEnumerable<TEntity> items = _repo.GetAll();

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

            TEntity item = _repo.GetById(itemToUpdateDTO.Id);
            if (item != null)
            {
                TEntity itemToUpdate = _mp.Map<TEntity>(itemToUpdateDTO);

                _repo.Update(itemToUpdate);            
            }
        }
    }
}
