using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComputerNet.DAL.Entities
{
    public class Building
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public Building()
        {
            Rooms = new List<Room>();        
        }
    }
}
