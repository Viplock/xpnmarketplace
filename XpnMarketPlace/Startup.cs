using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XpnMarketPlace.Startup))]
namespace XpnMarketPlace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
