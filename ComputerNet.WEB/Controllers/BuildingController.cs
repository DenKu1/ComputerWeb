using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;
using System.Web.Mvc;

namespace ComputerNet.WEB.Controllers
{
    [Authorize]
    public class BuildingController : GenericController<BuildingDTO, BuildingVM>
    {
        public BuildingController(IMapper mapper, IGenericService<BuildingDTO> service) : base(mapper, service)
        {
        }
    }
}