using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arkadas.Startup))]
namespace Arkadas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
