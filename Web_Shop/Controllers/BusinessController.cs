using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_Shop.Models;
using Web_Shop.Helpers;

namespace Web_Shop.Controllers
{
    //[Authorize]
    public class BusinessController : Controller
    {
        private ShopContext db = new ShopContext();

        BusinessModel businessModel; 

        // GET: Business
        public async Task<ActionResult> Index()
        {
            businessModel = new BusinessModel();
            businessModel.BuyDescription = "My BuyDescription";
            businessModel.Price = 10.5M;
            businessModel.IsOk = true;

            return View(businessModel);
        }

        [Authorize(Roles = "manager")]
        //[Authorize]
        [MyAction]
        public async Task<ActionResult> AllGoods()
        {
            businessModel = new BusinessModel();
            businessModel.BuyDescription = "My New BuyDescription";
            businessModel.Price = 12.3M;
            businessModel.IsOk = true;
            businessModel.Group = "AllGoods Group";

            return View(businessModel);
        }

        // GET: Business/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            BusinessModel businessModel = await db.BusinessModels.FindAsync(id);

            if (businessModel == null)
            {
                return HttpNotFound();
            }
            return View(businessModel);
        }

        // GET: Business/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Business/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "UserId,IsOk,BuyDescription,Group,Price")] BusinessModel businessModel)
        {
            if (ModelState.IsValid)
            {
                db.BusinessModels.Add(businessModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(businessModel);
        }

        // GET: Business/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessModel businessModel = await db.BusinessModels.FindAsync(id);
            if (businessModel == null)
            {
                return HttpNotFound();
            }
            return View(businessModel);
        }

        // POST: Business/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserId,IsOk,BuyDescription,Group,Price")] BusinessModel businessModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(businessModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(businessModel);
        }

        // GET: Business/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinessModel businessModel = await db.BusinessModels.FindAsync(id);
            if (businessModel == null)
            {
                return HttpNotFound();
            }
            return View(businessModel);
        }

        // POST: Business/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            BusinessModel businessModel = await db.BusinessModels.FindAsync(id);
            db.BusinessModels.Remove(businessModel);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
