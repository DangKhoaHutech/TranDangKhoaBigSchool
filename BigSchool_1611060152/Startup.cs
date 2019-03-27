using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool_1611060152.Startup))]
namespace BigSchool_1611060152
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
