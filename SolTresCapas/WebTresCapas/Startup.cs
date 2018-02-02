using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTresCapas.Startup))]
namespace WebTresCapas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
