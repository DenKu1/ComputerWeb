using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;

namespace ComputerNet.WEB.Controllers
{
    public class BuildingController : GenericController<BuildingDTO, BuildingVM>
    {
        public BuildingController(IMapper mapper, IGenericService<BuildingDTO> service) : base(mapper, service)
        {
        }
    }
}