using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinTestWebApp2015.Startup))]
namespace JenkinTestWebApp2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
