﻿using System.Collections.Generic;

namespace ComputerNet.BLL.Interfaces
{
    public interface IGenericService<TEntityDTO>
    {
        void Create(TEntityDTO item);
        TEntityDTO GetById(int id);
        IEnumerable<TEntityDTO> GetAll();
        void Update(TEntityDTO itemToUpdate);
        void Delete(int id);
    }
}
