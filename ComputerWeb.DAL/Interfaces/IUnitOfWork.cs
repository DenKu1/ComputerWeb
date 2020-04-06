using ComputerNet.DAL.Entities;
using ComputerNet.DAL.Repositories;
using System;

namespace ComputerNet.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<Building> Buildings { get; }
        GenericRepository<Computer> Computers { get; }
        GenericRepository<Room> Rooms { get; }
        GenericRepository<Router> Routers { get; }

        void Save();

        GenericRepository<T> Set<T>() where T : class;
    }
}
