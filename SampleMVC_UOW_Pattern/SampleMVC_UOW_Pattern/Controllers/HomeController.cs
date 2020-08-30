using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC_UOW_Pattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bien = "From staff 1 = modify Home controller";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}