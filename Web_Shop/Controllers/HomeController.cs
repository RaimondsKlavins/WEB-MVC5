using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Shop.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Web_Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ShopContext();

            ViewBag.Books = from book in db.Books select book.BookName;

            return View();
        }

        public ActionResult About()
        {
            //AddRoles();

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private void AddRoles()
        {

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                // создаем две роли
                //var roleAdmin = new IdentityRole { Name = "admin" };
                //var roleUser = new IdentityRole { Name = "user" };
                var roleAcc = new IdentityRole { Name = "accaunter" };
                var roleMng = new IdentityRole { Name = "manager" };
                var roleSto = new IdentityRole { Name = "stockchecker" };
                var roleOwn = new IdentityRole { Name = "siteowner" };

                // добавляем роли в бд
                //roleManager.Create(roleAdmin);
                //roleManager.Create(roleUser);
                var res1 = roleManager.Create(roleAcc);
                var res2 = roleManager.Create(roleMng);
                var res3 = roleManager.Create(roleSto);
                var res4 = roleManager.Create(roleOwn);

                // создаем пользователей
                //var user = new ApplicationUser { Email = "alex@mail.ru", UserName = "alex@mail.ru" };
                //string password = "Alex!2";
                //var result = userManager.Create(user, password);

                var user = new ApplicationUser { Email = "alex@mail.ru", UserName = "alex@mail.ru" };

                //if (result.Succeeded)
                //{
                // добавляем для пользователя роль 223ba0a5-9d56-4374-a3b7-38c831cfbc5f
                userManager.AddToRole("223ba0a5-9d56-4374-a3b7-38c831cfbc5f", roleAcc.Name);
                userManager.AddToRole("223ba0a5-9d56-4374-a3b7-38c831cfbc5f", roleMng.Name);
                userManager.AddToRole("223ba0a5-9d56-4374-a3b7-38c831cfbc5f", roleSto.Name);
                userManager.AddToRole("223ba0a5-9d56-4374-a3b7-38c831cfbc5f", roleOwn.Name);
                //}

                context.SaveChanges();
            }
        }

    }
}