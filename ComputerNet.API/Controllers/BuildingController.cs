using AutoMapper;
using ComputerNet.API.Models;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;

namespace ComputerNet.API.Controllers
{
    public class BuildingController : GenericController<BuildingDTO, BuildingVM>
    {
        public BuildingController(IMapper mapper, IGenericService<BuildingDTO> service) : base(mapper, service)
        {
        }
    }
}