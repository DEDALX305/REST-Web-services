using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(REST_API.Startup))]
namespace REST_API
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
