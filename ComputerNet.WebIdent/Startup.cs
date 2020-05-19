using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComputerNet.WebIdent.Startup))]
namespace ComputerNet.WebIdent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
