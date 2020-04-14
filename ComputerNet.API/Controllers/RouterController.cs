using AutoMapper;
using ComputerNet.API.Models;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;

namespace ComputerNet.API.Controllers
{
    public class RouterController : GenericController<RouterDTO, RouterVM>
    {
        public RouterController(IMapper mapper, IGenericService<RouterDTO> service) : base(mapper, service)
        {
        }
    }
}