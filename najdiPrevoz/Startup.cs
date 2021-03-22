using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(najdiPrevoz.Startup))]
namespace najdiPrevoz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
