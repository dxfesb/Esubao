using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Esubao.Models;
using System.Text.RegularExpressions;

namespace Esubao.Controllers.MT
{
    public class HelpeController : Controller
    {
        // GET: Helpe
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HelpeIndex()
        {
            return View();
        }

        /// <summary>
        /// 留言敏感词过滤
        /// </summary>
        /// <returns></returns>
        public ActionResult Test(string content) {
            string[] arr = {  "白痴", "傻子", "你妹", "垃圾", "废物" };
            string xingxing = String.Empty;
            foreach (var item in arr)
            {
                if (content.Contains(item))
                {
                    var num = item.Length;
                    xingxing = string.Empty;
                    for (int i = 1; i <= num; i++)
                    {
                        xingxing += "*";
                        if (i == num)
                        {

                            content = content.Replace(item, xingxing);
                        }
                    }
                }
            }
            return Json(content);
        }
        /// <summary>
        /// 资讯与建议
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Advicesuggestions(ZiXunJianYi advicesu)
        {
            using (EsuBaoEntities Esubao = new EsuBaoEntities())
            {
                advicesu.MessDate = DateTime.Now.Date;
                var list = Esubao.ZiXunJianYis.Add(advicesu);
                int rs = Esubao.SaveChanges();
                var obj = new { msg = "客官，不好意思，系统正在维护", code = 201 };
                if (rs > 0)
                {
                    obj = new { msg = "客官，收到您的建议了喔", code = 200 };
                }
                return Json(obj);
            }
        }
        /// <summary>
        /// 留言查询
        /// </summary>
        /// <returns></returns>
        public JsonResult Leavingmess() {
            using (EsuBaoEntities Esubao = new EsuBaoEntities())
            {
                var list = Esubao.ZiXunJianYis.ToList()
                    .Select(c=>new {
                    Id=c.Id,
                    Mail_box= c.Mail_box,
                    Message=c.Message,
                    Message_person=c.Message_person,
                    Message_type=c.Message_type,
                    title=c.title,
                    MessDate=c.MessDate.ToString("yyyy-MM-dd"),
                    Waybill_No= c.Waybill_No
                });
                return Json(list,JsonRequestBehavior.AllowGet);
            }

            }


        public ActionResult HelpZiXun()
        {

            return View();
        }
        public ActionResult Jin()
        {
            return View();
        }
        public ActionResult HelpZiLiao()
        {
            return View();
        }
    }
}