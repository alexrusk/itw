using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(itstep_webapp.Startup))]
namespace itstep_webapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
