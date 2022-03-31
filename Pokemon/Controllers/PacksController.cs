using Pokemon.Models;
using Pokemon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class PacksController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();


        // GET: Packs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuyPack(string userid,int packvalue)
        {
            var cards = db.Cards.Where(c => c.ApplicationUserId == null).ToList();
            CreatePack.NewPack(packvalue, cards,userid);

            return View();
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