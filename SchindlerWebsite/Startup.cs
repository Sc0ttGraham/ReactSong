using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchindlerWebsite.Startup))]
namespace SchindlerWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
