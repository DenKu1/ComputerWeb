using System.ComponentModel.DataAnnotations;

namespace ComputerNet.API.Models
{
    public class RoomVM
    {
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int BuildingId { get; set; }
    }
}