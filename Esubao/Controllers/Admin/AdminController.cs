using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Esubao.Models;

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
        /// 后台登录功能
        /// <paramref name="user"/>
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminLogin(T_AdminUser user)
        {
          
            using (EsuBaoEntities Esubao = new EsuBaoEntities()) {

                var LoginList = Esubao.T_AdminUser.Where(c => c.AdminName == user.AdminName && c.AdminPwd == user.AdminPwd).FirstOrDefault();
                if (LoginList!=null) {
                    Session["T_AdminUser"] = LoginList;
                    return RedirectToAction("AdminIndex");
                }
                return RedirectToAction("Login");
                
            }   
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
            T_AdminUser u = Session["T_AdminUser"] as T_AdminUser;

            return View();
        }
       
    }
}