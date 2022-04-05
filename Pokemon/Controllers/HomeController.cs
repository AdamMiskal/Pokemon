using Microsoft.AspNet.Identity;
using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        [RequireHttps]
        public ActionResult Index(ApplicationDbContext db)
        {
            var card = db.Cards.ToList();
            return View(card);
        }


        public ActionResult _NavigationBar(ApplicationDbContext db)
        {
            var user = db.Users.Where(x => x.Id == User.Identity.GetUserId());

            return PartialView("_NavigationBar.cshtml", user);
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