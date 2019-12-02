using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(clienteServiciosWeb.Startup))]
namespace clienteServiciosWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
