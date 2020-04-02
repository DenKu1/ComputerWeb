using System.ComponentModel.DataAnnotations;

namespace ComputerNet.WEB.Models
{
    public class BuildingVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}