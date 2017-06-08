using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gamenseni.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["msg"] = "Hello World !";
            return View();
        }

        // GET: Send
        [HttpPost]
        public ActionResult Send(string value1)
        {
            ViewData["PostData"] = value1 + "を受け取りました。";
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