using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class MyCollectionController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: MyCollection
        public ActionResult Index()
        { 
            
            return View(db.Users.ToList());
        }

        
    }
}