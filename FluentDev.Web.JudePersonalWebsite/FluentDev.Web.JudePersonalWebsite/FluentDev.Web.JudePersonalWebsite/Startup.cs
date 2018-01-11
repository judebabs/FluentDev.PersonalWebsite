using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FluentDev.Web.JudePersonalWebsite.Startup))]
namespace FluentDev.Web.JudePersonalWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
