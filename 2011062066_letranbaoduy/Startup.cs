using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011062066_letranbaoduy.Startup))]
namespace _2011062066_letranbaoduy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
