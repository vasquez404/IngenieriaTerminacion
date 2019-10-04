using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IngenieriaTerminacion.Startup))]
namespace IngenieriaTerminacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
