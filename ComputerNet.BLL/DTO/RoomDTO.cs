using ComputerNet.DAL.Interfaces;

namespace ComputerNet.BLL.DTO
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int BuildingId { get; set; }    
    }
}
