using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GavinTestWeb4.Startup))]
namespace GavinTestWeb4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
