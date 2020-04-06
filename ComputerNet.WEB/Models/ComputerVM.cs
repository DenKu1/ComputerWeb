using System;
using System.ComponentModel.DataAnnotations;

namespace ComputerNet.WEB.Models
{
    public class ComputerVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public DateTime Manufactured { get; set; }
        public long? LogicAddress { get; set; }
        public long? Mask { get; set; }
        [Required]
        public string HardwareAddress { get; set; }
        [Required]
        public int RoomId { get; set; }
        public int? RouterId { get; set; }
    }
}