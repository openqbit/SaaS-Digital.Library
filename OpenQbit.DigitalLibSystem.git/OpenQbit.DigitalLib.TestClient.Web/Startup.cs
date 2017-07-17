using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQbit.DigitalLib.TestClient.Web.Startup))]
namespace OpenQbit.DigitalLib.TestClient.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
