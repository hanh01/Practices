using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAuthenlication.Startup))]
namespace TestAuthenlication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
