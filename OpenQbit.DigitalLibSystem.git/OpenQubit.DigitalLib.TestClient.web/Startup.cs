using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQubit.DigitalLib.TestClient.web.Startup))]
namespace OpenQubit.DigitalLib.TestClient.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
