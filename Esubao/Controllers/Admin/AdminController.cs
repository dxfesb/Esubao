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
        /// 咨询与投诉管理数据查询
        /// </summary>
        /// <returns></returns>
        public JsonResult Advicemesslist()
        {
            using (EsuBaoEntities Esubao = new EsuBaoEntities())
            {
                var list = Esubao.ZiXunJianYis.ToList()
                    .Select(c => new {
                        Id = c.Id,
                        Mail_box = c.Mail_box,
                        Message = c.Message,
                        Message_person = c.Message_person,
                        Message_type = c.Message_type,
                        title = c.title,
                        MessDate = c.MessDate.ToString("yyyy-MM-dd"),
                        Waybill_No = c.Waybill_No,
                        Contact_number= c.Contact_number
                    });
                return Json(list, JsonRequestBehavior.AllowGet);
            }

        }
        /// <summary>
        /// 咨询与建议数据删除
        /// </summary>
        /// <returns></returns>
        public JsonResult AdvicemessDel(int id) {
            using (EsuBaoEntities Esubao = new EsuBaoEntities()) {
                var list = Esubao.ZiXunJianYis.Where(c => c.Id == id).FirstOrDefault();
                Esubao.ZiXunJianYis.Remove(list);
                int rs = Esubao.SaveChanges();
                var obj = new { msg = "删除失败", code = 201 };
                if (rs > 0) {
                    obj = new { msg = "删除成功", code = 200 };
                }
                return Json(obj);
            }
        }

        /// <summary>
        /// 咨询与建议后台数据回复页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Adviceinfor()
        {

            return View();
        }
        /// <summary>
        /// 咨询与建议后台管理页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AdviceLaunch() {

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
            T_AdminUser u = Session["T_AdminUser"] as T_AdminUser;

            return View();
        }
        /// <summary>
        /// 用户信息管理
        /// </summary>
        /// <returns></returns>

        public ActionResult UserAdmin() {
            return View();
        }
        /// <summary>
        /// 用户信息查询
        /// </summary>
        /// <returns></returns>
        public JsonResult UserList() {
            using (EsuBaoEntities Esubao = new EsuBaoEntities()) {
                var list = Esubao.Users.ToList().Select(c => new
                {
                    User_Id = c.User_Id,
                    User_uaername = c.User_uaername,
                    User_password = c.User_password,
                    User_Name = c.User_Name,
                    User_Sex = c.User_Sex,
                    User_Company = c.User_Company,
                    User_fixedphone = c.User_fixedphone,
                    User_Phone = c.User_Phone,
                    User_Email = c.User_Email,
                    User_city = c.User_city,
                    User_note = c.User_note,
                    User_status = c.User_note == "可用" ? "冻结" : "解冻"
                });
                return Json(list, JsonRequestBehavior.AllowGet);
            }

        }
        /// <summary>
        /// 冻结账户
        /// </summary>
        /// <returns></returns>
        public JsonResult Freeze(int id,string User_note) {
            using (EsuBaoEntities Esubao = new EsuBaoEntities()) {
                var list = Esubao.Users.Where(c => c.User_Id == id).FirstOrDefault();
                list.User_note = User_note;
                int rs= Esubao.SaveChanges();
                var obj = new { msg = "更改失败", code = 201 };
                if (rs > 0) {
                    obj = new { msg = "更改成功", code = 200 };
                }
                return Json(obj);
            }
        }
    }
}