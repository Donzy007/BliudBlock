using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BliudBlock.WebUI.Startup))]
namespace BliudBlock.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
