using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Esubao.Controllers.MT
{
    public class HelperController : Controller
    {
        // GET: Helper
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HelperIndex() {
            return View();
        }
        public ActionResult Jin() {
            return View();
        }
    }
}