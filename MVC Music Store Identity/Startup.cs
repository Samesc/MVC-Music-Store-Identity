using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Music_Store_Identity.Startup))]
namespace MVC_Music_Store_Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
