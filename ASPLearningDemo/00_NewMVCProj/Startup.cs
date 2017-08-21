using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_00_NewMVCProj.Startup))]
namespace _00_NewMVCProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
