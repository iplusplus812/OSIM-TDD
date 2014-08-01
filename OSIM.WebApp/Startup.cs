using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OSIM.WebApp.Startup))]
namespace OSIM.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
