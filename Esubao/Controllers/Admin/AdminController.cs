using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Esubao.Controllers.Admin
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();

        }
        /// <summary>
        /// 后台登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login() {

            return View();
        }
        /// <summary>
        /// 后台首页
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminIndex()
        {

            return View();
        }
       
    }
}