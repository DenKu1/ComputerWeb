using ComputerNet.DAL.Interfaces;
using System;

namespace ComputerNet.DAL.Entities
{
    public class Computer : IRequireId
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime Manufactured { get; set; }
        public long LogicAddress { get; set; }
        public long Mask { get; set; }
        public string HardwareAddress { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int RouterId { get; set; }
        public Router Router { get; set; }
    }
}
