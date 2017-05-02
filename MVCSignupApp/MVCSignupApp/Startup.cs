using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSignupApp.Startup))]
namespace MVCSignupApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
