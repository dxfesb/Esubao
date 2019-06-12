using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Esubao.Controllers.ZHX
{
    public class RegistersController : Controller
    {
        // GET: Registers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration_page()
        { return View(); }
    }
}