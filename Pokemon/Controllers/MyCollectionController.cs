using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Data.SqlClient;
using Microsoft.AspNet.Identity;

namespace Pokemon.Controllers
{
    public class MyCollectionController : Controller
    {
         ApplicationDbContext db = new ApplicationDbContext();

        // GET: MyCollection
        public ActionResult Index()
        {

            
            //var keepo = db.Users.Join(db.Cards, u => u.Id, c => c.ApplicationUserId, (u, c) => new { u, c }).ToList();

            // var kfd = db.Users.ToList().Find(u => u.UserName == "admin@gmail.com").Cards;
            var keepo = db.Users.Find(User.Identity.GetUserId());
            var cards = db.Cards.Where(x => x.ApplicationUserId == keepo.Id).Include(x=>x.Image).ToList();


            return View(cards);
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



