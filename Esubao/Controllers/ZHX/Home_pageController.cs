using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Esubao.Controllers.ZHX
{
    public class Home_pageController : Controller
    {
        // GET: Home_page
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult home_page()
        { return View(); }
    }
}