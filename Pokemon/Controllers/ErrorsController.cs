using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class ErrorsController : Controller
    {
        // GET: Errors
        public ActionResult Index(string message)
        {
            ViewBag.message = message;
            return View();
        }
    }
}