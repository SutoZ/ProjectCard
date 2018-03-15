using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectCard.Startup))]
namespace ProjectCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
