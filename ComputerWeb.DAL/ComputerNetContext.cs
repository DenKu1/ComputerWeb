using ComputerNet.DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ComputerNet.DAL
{
    public class ComputerNetContext : IdentityDbContext<User>
    {
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Router> Routers { get; set; }

        public ComputerNetContext() : base("ComputerNetDBConnection")
        {
        }

        static ComputerNetContext()
        {
           // Database.SetInitializer(new ComputerNetDbInitializer());
        }
    }
}
