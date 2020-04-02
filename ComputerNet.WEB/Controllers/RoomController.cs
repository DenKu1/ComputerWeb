using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;

namespace ComputerNet.WEB.Controllers
{
    public class RoomController : GenericController<RoomDTO, RoomVM>
    {
        public RoomController(IMapper mapper, IGenericService<RoomDTO> service) : base(mapper, service)
        {
        }

    }
}
