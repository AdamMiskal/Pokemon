﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class CardDatabaseController : Controller
    {
        // GET: CardDatabase
        public ActionResult Index()
        {
            return View();
        }
    }
}