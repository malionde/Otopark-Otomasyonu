using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Otopark_Web.Startup))]
namespace Otopark_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
