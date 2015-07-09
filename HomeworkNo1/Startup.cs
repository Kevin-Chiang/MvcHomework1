using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeworkNo1.Startup))]
namespace HomeworkNo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
