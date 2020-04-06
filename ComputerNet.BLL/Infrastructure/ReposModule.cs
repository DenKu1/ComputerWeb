using Ninject.Modules;
using Ninject.Web.Common;
using ComputerNet.DAL.Interfaces;
using ComputerNet.DAL.Repositories;

namespace ComputerNet.BLL.Infrastructure
{
    public class ReposModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
        }
    }
}
