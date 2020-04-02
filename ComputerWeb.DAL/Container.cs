using ComputerNet.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerNet.DAL
{
    static public class Container
    {
        public static List<Building> Buildings { get; set; }
        public static List<Room> Rooms { get; set; }
        public static List<Router> Routers { get; set; }
        public static List<Computer> Computers { get; set; }

        static Container()
        {
            Buildings = new List<Building>();
            Rooms = new List<Room>();
            Routers = new List<Router>();
            Computers = new List<Computer>();

            Initialize();
        }

        public static List<T> Set<T>() where T : class
        {
            if (typeof(T) == typeof(Building))
            {
                return (List<T>)Buildings.Cast<T>();
            }
            if (typeof(T) == typeof(Room))
            {
                return (List<T>)Rooms.Cast<T>();
            }
            if (typeof(T) == typeof(Router))
            {
                return (List<T>)Routers.Cast<T>();
            }
            if (typeof(T) == typeof(Computer))
            {
                return (List<T>)Computers.Cast<T>();
            }
            return null;
        }

        static void Initialize()
        {
            Computer c1 = new Computer { Id = 1, Model = "PC", Manufactured = DateTime.Now, HardwareAddress = "90-1F-12-22-33-55", LogicAddress = 2, };
            Computer c2 = new Computer { Id = 2, Model = "PC2", Manufactured = DateTime.Now.AddDays(-1), HardwareAddress = "90-1F-12-22-33-54", LogicAddress = 22 };

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

            Computers.Add(c1);
            Computers.Add(c2);
            Routers.Add(r1);
            Rooms.Add(rm1);
            Buildings.Add(b1);   
        }

    }
}
