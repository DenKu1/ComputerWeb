using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.BLL.Services;
using Ninject.Modules;
using Ninject.Web.Common;

namespace ComputerNet.API.Infrastructure
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericService<BuildingDTO>>().To<BuildingService>().InRequestScope();
            Bind<IGenericService<ComputerDTO>>().To<ComputerService>().InRequestScope();
            Bind<IGenericService<RoomDTO>>().To<RoomService>().InRequestScope();
            Bind<IGenericService<RouterDTO>>().To<RouterService>().InRequestScope();
        }
    }
}