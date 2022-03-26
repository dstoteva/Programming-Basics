using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sumator.Startup))]
namespace sumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
