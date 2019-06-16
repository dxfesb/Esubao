using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Esubao.Models;
using Esubao.Controllers;

namespace Esubao.Controllers.ZHX
{
    public class LoginindexController : Controller
    {
        // GET: Loginindex
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult loginindex()
        {
            return View();
        }
        public ActionResult UserLogin(User user)
        {

            using (EsuBaoEntities Esubao = new EsuBaoEntities())
            {

                var LoginList = Esubao.Users.Where(c => c.User_uaername == user.User_uaername && c.User_password == user.User_password &&c.User_note=="可用").FirstOrDefault();
                if (LoginList != null)
                {
                    Session["T_User"] = LoginList;
                    return RedirectToAction("home_page", "Home_page");
                }
                return RedirectToAction("/LoginIndex");
            }
        }
    }
}