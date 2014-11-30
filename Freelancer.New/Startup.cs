using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Freelancer.New.Startup))]
namespace Freelancer.New
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
