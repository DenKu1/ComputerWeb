using System.ComponentModel.DataAnnotations;

namespace ComputerNet.WEB.Models
{
    public class UserRegisterVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}