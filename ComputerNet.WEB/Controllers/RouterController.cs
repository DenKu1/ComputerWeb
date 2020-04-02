using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;

namespace ComputerNet.WEB.Controllers
{
    public class RouterController : GenericController<RouterDTO, RouterVM>
    {
        public RouterController(IMapper mapper, IGenericService<RouterDTO> service) : base(mapper, service)
        {
        }
    }
}