using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;
using System.Web.Mvc;

namespace ComputerNet.WEB.Controllers
{
    [Authorize]
    public class RoomController : GenericController<RoomDTO, RoomVM>
    {
        public RoomController(IMapper mapper, IGenericService<RoomDTO> service) : base(mapper, service)
        {
        }

    }
}
