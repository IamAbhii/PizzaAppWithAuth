using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaHelpCenterAppV1.Startup))]
namespace PizzaHelpCenterAppV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
