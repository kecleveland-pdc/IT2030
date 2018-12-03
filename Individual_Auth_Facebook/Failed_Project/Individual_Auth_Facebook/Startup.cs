using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Individual_Auth_Facebook.Startup))]
namespace Individual_Auth_Facebook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
