using AutoMapper;
using ComputerNet.BLL.Infrastructure;
using Ninject.Modules;

namespace ComputerNet.API.Infrastructure
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
                cfg.AddProfile<APIMapperProfile>();
                cfg.AddProfile<BLLMapperProfile>();
            });

            return mapperConfiguration;
        }
    }
}