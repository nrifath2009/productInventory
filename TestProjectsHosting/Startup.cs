using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProjectsHosting.Startup))]
namespace TestProjectsHosting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
