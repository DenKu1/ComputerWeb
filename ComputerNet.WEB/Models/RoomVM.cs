using System.ComponentModel.DataAnnotations;

namespace ComputerNet.WEB.Models
{
    public class RoomVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int BuildingId { get; set; }
    }
}