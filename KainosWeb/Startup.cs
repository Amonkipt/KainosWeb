using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KainosWeb.Startup))]
namespace KainosWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
