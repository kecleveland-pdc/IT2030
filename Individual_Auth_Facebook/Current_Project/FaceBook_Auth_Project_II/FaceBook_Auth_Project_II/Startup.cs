using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FaceBook_Auth_Project_II.Startup))]
namespace FaceBook_Auth_Project_II
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
