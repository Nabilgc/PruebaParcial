using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCParcial.Startup))]
namespace MVCParcial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
