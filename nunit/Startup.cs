using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nunit.Startup))]
namespace nunit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
