using System.Collections.Generic;

namespace ComputerNet.DAL.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public int BuildingId { get; set; }
        public virtual Building Building { get; set; }

        public virtual ICollection<Router> Routers { get; set; }
        public virtual ICollection<Computer> Computers { get; set; }

        public Room()
        {
            Routers = new List<Router>();
            Computers = new List<Computer>();
        }
    }
}
