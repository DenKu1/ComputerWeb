using System.Collections.Generic;

namespace ComputerNet.DAL.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int BuildingId { get; set; }
        public Building Building { get; set; }

        public ICollection<Router> Routers { get; set; }
        public ICollection<Computer> Computers { get; set; }

        public Room()
        {
            Routers = new List<Router>();
            Computers = new List<Computer>();
        }
    }
}
