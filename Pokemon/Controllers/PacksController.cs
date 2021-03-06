using Microsoft.AspNet.Identity;
using Pokemon.Models;
using Pokemon.Models.HelperModels;
using Pokemon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            //var userId = User.Identity.GetUserId();
            //var Usser = db.Users.Find(userId);
            return View();

        }

        
        public ActionResult BuyPack(BuyPackModel model)
        {
            var user = db.Users.Find(model.UserId);
            if (user.Balance < model.PackValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);//tha to allaksoume me ena view diko mas
            }

            var cards = db.Cards.Where(c => c.ApplicationUserId == null).ToList();
            var newPack = CreatePack.NewPack(model.PackValue, cards, model.UserId);
            db.SaveChanges();
           return View(newPack);
        }

        public ActionResult FirePack()
		{
            return View();
		}

        public ActionResult LeafPack()
        {
            return View();
        }

        public ActionResult WaterPack()
        {
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