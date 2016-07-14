using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisitorPatternWebDemo2.Startup))]
namespace VisitorPatternWebDemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
