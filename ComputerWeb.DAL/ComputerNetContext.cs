using ComputerNet.DAL.Entities;
using System.Data.Entity;

namespace ComputerNet.DAL
{
    public class ComputerNetContext : DbContext
    {
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Router> Routers { get; set; }

        static ComputerNetContext()
        {
            Database.SetInitializer(new ComputerNetDbInitializer());
        }

        public ComputerNetContext() : base("ComputerNetDBConnection")
        {
        }
    }
}
