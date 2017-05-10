using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Protocolo.Startup))]
namespace Protocolo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
