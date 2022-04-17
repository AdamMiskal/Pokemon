using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class EditProfileController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: EditProfile
        public ActionResult Index(string id)
        {
            var user = db.Users.Find(id);
            return View(user);
        }

        // GET: User/Edit

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser appUser = db.Users.Find(id);
            if (appUser == null)
            {
                return HttpNotFound();
            }
            return View(appUser);
        }

        // POST: User/Edit/
        [HttpPost]
        public ActionResult Edit(ApplicationUser appUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appUser);
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