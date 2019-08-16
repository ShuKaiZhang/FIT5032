using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week03.Startup))]
namespace Week03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
