using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Frete4U.Startup))]
namespace Frete4U
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
