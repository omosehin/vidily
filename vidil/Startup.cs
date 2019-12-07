using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidil.Startup))]
namespace vidil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
