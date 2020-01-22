using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LovgrenMIS4200.Startup))]
namespace LovgrenMIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
