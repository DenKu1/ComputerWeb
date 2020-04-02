using ComputerNet.DAL.Interfaces;
using System.Collections.Generic;

namespace ComputerNet.DAL.Entities
{
    public class Building : IRequireId
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public Building()
        {
            Rooms = new List<Room>();        
        }
    }
}
