using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\kelse\Desktop\Logs\log2.txt", text);

            //Random rnd = new Random(10);
            //var num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("");

            //return RedirectToACtion("Contact");

            //ViewBag.RandomNumber = num;
            //return View();

            List<string> names = new List<string>
            {
                "jesse",
                "adam",
                "Brett",
            };
            return View(names);
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