using Microsoft.Owin;
using Web_Shop.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Shop.Startup))]
namespace Web_Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
