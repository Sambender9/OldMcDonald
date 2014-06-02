using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OldMcDonald.web.Startup))]
namespace OldMcDonald.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
