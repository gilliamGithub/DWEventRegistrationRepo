using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DrachenwaldEventRegistration.Startup))]
namespace DrachenwaldEventRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
