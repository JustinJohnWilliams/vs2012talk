using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vs2012talk.Models;

namespace vs2012talk.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Modal()
        {
            return PartialView("_modal");
        }

        [HttpPost]
        public ActionResult Create(IndexViewModel model)
        {
            return View();
        }

    }
}
