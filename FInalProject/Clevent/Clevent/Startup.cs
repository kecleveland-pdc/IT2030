using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clevent.Startup))]
namespace Clevent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
