using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RandomPlay.Startup))]
namespace RandomPlay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
