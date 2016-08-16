using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yogaRx.Startup))]
namespace yogaRx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
