using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Esubao.Models;

namespace Esubao.Controllers.LWJ
{
    public class ShejiController : Controller
    {
        // GET: Sheji
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ziliao()
        {
            return View();
        }
        public ActionResult Guanyu()
        {
            return View();
        }
        public ActionResult Jieshao()
        {
            return View();
        }
        public ActionResult Jingyun()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Updata(T_AdminUser emp)
        {
            EsuBaoEntities db = new EsuBaoEntities();
            db.T_AdminUser.Add(emp);
            int rs = db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpPost]
        public JsonResult Delete(int id)
        {
            EsuBaoEntities db = new EsuBaoEntities();
            var emp = db.T_AdminUser.Where(c => c.AdminID == id).FirstOrDefault();
            db.T_AdminUser.Remove(emp);
            int rs = db.SaveChanges();
            var obj = new { msg = "删除失败", code = 201 };
            if (rs > 0)
            {
                obj = new { msg = "删除成功", code = 200 };
            }
            return Json(obj);
        }
    }
}