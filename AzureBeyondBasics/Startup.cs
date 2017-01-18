using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureBeyondBasics.Startup))]
namespace AzureBeyondBasics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
