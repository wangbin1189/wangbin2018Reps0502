using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PowerKSI.Startup))]
namespace PowerKSI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
