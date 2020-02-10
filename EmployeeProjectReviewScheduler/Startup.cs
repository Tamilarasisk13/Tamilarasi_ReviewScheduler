using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeProjectReviewScheduler.Startup))]
namespace EmployeeProjectReviewScheduler
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
