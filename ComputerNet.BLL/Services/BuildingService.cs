using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.DAL.Entities;
using ComputerNet.DAL.Interfaces;

namespace ComputerNet.BLL.Services
{
    public class BuildingService : GenericService<Building, BuildingDTO>
    {
        public BuildingService(IGenericRepository<Building> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}