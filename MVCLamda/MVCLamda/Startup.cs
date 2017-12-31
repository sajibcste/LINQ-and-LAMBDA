using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLamda.Startup))]
namespace MVCLamda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
