using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cms_Project.Startup))]
namespace Cms_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
