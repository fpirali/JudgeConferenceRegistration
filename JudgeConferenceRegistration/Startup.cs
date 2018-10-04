using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JudgeConferenceRegistration.Startup))]
namespace JudgeConferenceRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
