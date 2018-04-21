using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aldiger.Startup))]
namespace aldiger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
