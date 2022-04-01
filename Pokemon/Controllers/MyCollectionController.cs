using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Data.SqlClient;

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
            var keepo = db.Users.Include(x=>x.Cards).ToList();
            

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



