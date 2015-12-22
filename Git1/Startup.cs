using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git1.Startup))]
namespace Git1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
