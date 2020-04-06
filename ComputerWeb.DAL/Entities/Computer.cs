using System;
using System.ComponentModel.DataAnnotations;

namespace ComputerNet.DAL.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        public DateTime Manufactured { get; set; }
        public long LogicAddress { get; set; }
        public long Mask { get; set; }
        [Required]
        public string HardwareAddress { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int RouterId { get; set; }
        public Router Router { get; set; }
    }
}
