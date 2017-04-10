using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nhsite700.Startup))]
namespace nhsite700
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
