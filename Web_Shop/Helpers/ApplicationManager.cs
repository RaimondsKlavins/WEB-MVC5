using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Web_Shop.Models;

namespace Web_Shop.Helpers
{
    public class ApplicationManager : UserManager<ApplicationUser>
    {
        public ApplicationManager(IUserStore<ApplicationUser> store) : base(store)
        {
        }

        public static ApplicationManager Create(IdentityFactoryOptions<ApplicationManager> options,
                                            IOwinContext context)
        {
            ApplicationDbContext db = context.Get<ApplicationDbContext>();
            ApplicationManager manager = new ApplicationManager(new UserStore<ApplicationUser>(db));
            return manager;
        }
    }
}