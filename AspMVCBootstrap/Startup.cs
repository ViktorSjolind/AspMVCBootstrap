using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMVCBootstrap.Startup))]
namespace AspMVCBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
