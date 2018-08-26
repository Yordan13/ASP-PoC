using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UtilitiesApp.Startup))]
namespace UtilitiesApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
