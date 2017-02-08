using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZenithSociety_MichaelJung_AlbertChen.Startup))]
namespace ZenithSociety_MichaelJung_AlbertChen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
