using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComputerNet.DAL.Entities
{
    public class Router
    {
        public int Id { get; set; } 
        public long LogicAddress { get; set; }
        public long Mask { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string HardwareAddress { get; set; }
        public DateTime Manufactured { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
        
        public ICollection<Computer> Computers { get; set; }

        public Router()
        {
            Computers = new List<Computer>();
        }
    }
}
