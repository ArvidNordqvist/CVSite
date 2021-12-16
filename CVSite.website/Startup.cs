using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CVSite.website.Startup))]
namespace CVSite.website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
