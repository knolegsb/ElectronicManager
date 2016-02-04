using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElectronicManager.Web.Startup))]
namespace ElectronicManager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
