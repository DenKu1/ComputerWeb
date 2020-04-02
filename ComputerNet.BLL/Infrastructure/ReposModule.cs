using Ninject.Modules;
using Ninject.Web.Common;
using ComputerNet.DAL.Interfaces;
using ComputerNet.DAL.Repositories;
using ComputerNet.DAL.Entities;

namespace ComputerNet.BLL.Infrastructure
{
    public class ReposModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericRepository<Building>>().To<GenericRepository<Building>>().InRequestScope();
            Bind<IGenericRepository<Computer>>().To<GenericRepository<Computer>>().InRequestScope();
            Bind<IGenericRepository<Room>>().To<GenericRepository<Room>>().InRequestScope();
            Bind<IGenericRepository<Router>>().To<GenericRepository<Router>>().InRequestScope();
        }
    }
}
