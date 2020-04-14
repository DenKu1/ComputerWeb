using AutoMapper;
using ComputerNet.API.Models;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;

namespace ComputerNet.API.Controllers
{
    public class RoomController : GenericController<RoomDTO, RoomVM>
    {
        public RoomController(IMapper mapper, IGenericService<RoomDTO> service) : base(mapper, service)
        {
        }
    }
}
