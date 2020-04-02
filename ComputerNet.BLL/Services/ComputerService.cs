using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.DAL.Entities;
using ComputerNet.DAL.Interfaces;

namespace ComputerNet.BLL.Services
{
    public class ComputerService : GenericService<Computer, ComputerDTO>
    {
        public ComputerService(IGenericRepository<Computer> repository, IMapper mapper) : base(repository, mapper)
        {         
        }
    }
}
