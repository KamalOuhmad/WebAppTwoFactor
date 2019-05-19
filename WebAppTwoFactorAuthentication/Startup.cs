using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTwoFactorAuthentication.Startup))]
namespace WebAppTwoFactorAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
