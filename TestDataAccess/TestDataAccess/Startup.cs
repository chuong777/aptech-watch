using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestDataAccess.Startup))]
namespace TestDataAccess
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
