using AutoMapper;
using ComputerNet.BLL.Infrastructure;
using Ninject.Modules;

namespace ComputerNet.WEB.Infrastructure
{
    public class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {            
            Bind<IMapper>().ToConstructor(c => new Mapper(Configure())).InSingletonScope();           
        }

        private MapperConfiguration Configure()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            { 
                cfg.AddProfile<WEBMapperProfile>();
                cfg.AddProfile<BLLMapperProfile>();
            });

            return mapperConfiguration;
        }
    }
}