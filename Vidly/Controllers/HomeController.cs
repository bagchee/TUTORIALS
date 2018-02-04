﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "Movies Inventory.";

            return View();
        }

        public ActionResult Customers()
        {
            ViewBag.Message = "Your Customers page.";

            return View();
        }
    }
}