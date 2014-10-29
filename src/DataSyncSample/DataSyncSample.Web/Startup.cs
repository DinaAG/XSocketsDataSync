using Microsoft.Owin;
using Owin;
using Serilog;
using XSockets.Logger;
using XSockets.Owin.Host;

[assembly: OwinStartupAttribute(typeof(DataSyncSample.Web.Startup))]
namespace DataSyncSample.Web
{
    public class MyLogger : XLogger
    {
        public MyLogger()
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Trace().MinimumLevel.Information().CreateLogger();
        }
    }
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.UseXSockets(true);
        }
    }
}
