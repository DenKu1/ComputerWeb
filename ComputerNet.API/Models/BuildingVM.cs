using System.ComponentModel.DataAnnotations;

namespace ComputerNet.API.Models
{
    public class BuildingVM
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}