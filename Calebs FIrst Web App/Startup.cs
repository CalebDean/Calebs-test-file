using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calebs_FIrst_Web_App.Startup))]
namespace Calebs_FIrst_Web_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
