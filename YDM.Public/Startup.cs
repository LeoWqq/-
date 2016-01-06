using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YDM.Public.Startup))]
namespace YDM.Public
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
