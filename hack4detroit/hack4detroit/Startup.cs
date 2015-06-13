using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hack4detroit.Startup))]
namespace hack4detroit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
