using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JewelryMakingInventory.Web.MVC.Startup))]
namespace JewelryMakingInventory.Web.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
