using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ComputerNet.DAL.Entities;

namespace ComputerNet.DAL
{
    class ComputerNetDbInitializer : DropCreateDatabaseAlways<ComputerNetContext>
    {
        protected override void Seed(ComputerNetContext db)
        {
            Computer c1 = new Computer { Id = 1, Model = "PC", Manufactured = DateTime.Now, HardwareAddress = "90-1F-12-22-33-55"};
            Computer c2 = new Computer { Id = 2, Model = "PC2", Manufactured = DateTime.Now.AddDays(-1), HardwareAddress = "90-1F-12-22-33-54"};

            Router r1 = new Router { Id = 1, Model = "R1", Manufactured = DateTime.Now, HardwareAddress = "90-1F-12-22-33-53", LogicAddress = 33, Mask = 4294967040, Computers = new List<Computer> { c1, c2 } };

            Room rm1 = new Room { Id = 1, Number = 521, Routers = new List<Router> { r1 }, Computers = new List<Computer> { c1, c2 } };

            Building b1 = new Building { Id = 1, Name = "MyBuilding", Rooms = new List<Room> { rm1 } };

            c1.Router = r1;
            c1.RouterId = r1.Id;
            c1.Room = rm1;
            c1.RoomId = rm1.Id;

            c2.Router = r1;
            c2.RouterId = r1.Id;
            c2.Room = rm1;
            c2.RoomId = rm1.Id;

            r1.Room = rm1;
            r1.RoomId = rm1.Id;

            rm1.Building = b1;
            rm1.BuildingId = b1.Id;

            db.Computers.Add(c1);
            db.Computers.Add(c2);
            db.Routers.Add(r1);
            db.Rooms.Add(rm1);
            db.Buildings.Add(b1);

            db.SaveChanges();
        }
    }
}
