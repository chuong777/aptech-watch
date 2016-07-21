using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AptechWatch.Startup))]
namespace AptechWatch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
