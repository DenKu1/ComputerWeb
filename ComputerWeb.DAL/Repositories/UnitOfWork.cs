using ComputerNet.DAL.Entities;
using ComputerNet.DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace ComputerNet.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ComputerNetContext context;

        private GenericRepository<Building> buildings;
        private GenericRepository<Computer> computers;
        private GenericRepository<Room> rooms;
        private GenericRepository<Router> routers;

        public UnitOfWork()
        {
            context = new ComputerNetContext();
            UserManager = new ApplicationUserManager(new UserStore<User>(context));
        }

        public ApplicationUserManager UserManager { get; }

        public GenericRepository<Building> Buildings =>
            buildings ?? (buildings = new GenericRepository<Building>(context));
        public GenericRepository<Computer> Computers =>
            computers ?? (computers = new GenericRepository<Computer>(context));
        public GenericRepository<Room> Rooms =>
            rooms ?? (rooms = new GenericRepository<Room>(context));
        public GenericRepository<Router> Routers =>
            routers ?? (routers = new GenericRepository<Router>(context));

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public GenericRepository<T> Set<T>() where T : class
        {
            if (typeof(T) == typeof(Building))
            {
                return Buildings as GenericRepository<T>;
            }
            if (typeof(T) == typeof(Room))
            {
                return Rooms as GenericRepository<T>;
            }
            if (typeof(T) == typeof(Router))
            {
                return Routers as GenericRepository<T>;
            }
            if (typeof(T) == typeof(Computer))
            {
                return Computers as GenericRepository<T>;
            }
            return null;
        }
    }
}
