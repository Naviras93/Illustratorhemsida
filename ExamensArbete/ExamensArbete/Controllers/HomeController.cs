using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamensArbete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Information()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}