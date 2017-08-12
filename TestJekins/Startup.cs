using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestJekins.Startup))]
namespace TestJekins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
