using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gamenseni.Startup))]
namespace gamenseni
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
