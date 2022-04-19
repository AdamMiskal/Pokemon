using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class SiteStatisticsController : Controller
    {
        // GET: SiteStatistics
        public ActionResult Index()
        {
            return View();
        }
    }
}