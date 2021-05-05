using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmlakOfisi.Startup))]
namespace EmlakOfisi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
