using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.DAL.Entities;
using ComputerNet.DAL.Interfaces;

namespace ComputerNet.BLL.Services
{
    public class RoomService : GenericService<Room, RoomDTO>
    {
        public RoomService(IGenericRepository<Room> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
