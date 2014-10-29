using Microsoft.Owin;
using Owin;
using XSockets.Owin.Host;

[assembly: OwinStartupAttribute(typeof(DataSyncSample.Web.Startup))]
namespace DataSyncSample.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.UseXSockets(true);
        }
    }
}
