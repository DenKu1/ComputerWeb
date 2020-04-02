using ComputerNet.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace ComputerNet.DAL.Entities
{
    public class Router : IRequireId
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime Manufactured { get; set; }
        public long LogicAddress { get; set; }
        public long Mask { get; set; }
        public string HardwareAddress { get; set; }
       
        public int RoomId { get; set; }
        public Room Room { get; set; }
        
        public ICollection<Computer> Computers { get; set; }

        public Router()
        {
            Computers = new List<Computer>();
        }
    }
}
