using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PliWeb.Startup))]
namespace PliWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
