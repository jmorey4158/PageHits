using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PageHits.Startup))]
namespace PageHits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
