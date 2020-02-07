using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectForm.Startup))]
namespace ProjectForm
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
