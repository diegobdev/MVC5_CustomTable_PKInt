using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_CustomTable_PKInt.Startup))]
namespace MVC5_CustomTable_PKInt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
