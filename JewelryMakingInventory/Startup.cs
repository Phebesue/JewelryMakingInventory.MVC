using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JewelryMakingInventory.Startup))]
namespace JewelryMakingInventory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
