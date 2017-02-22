using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tab.Web.Startup))]
namespace Tab.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
