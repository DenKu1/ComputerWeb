using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.DAL.Entities;
using ComputerNet.DAL.Interfaces;

namespace ComputerNet.BLL.Services
{
    public class RouterService : GenericService<Router, RouterDTO>
    {
        public RouterService(IGenericRepository<Router> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
