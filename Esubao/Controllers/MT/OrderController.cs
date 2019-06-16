using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Esubao.Models;
namespace Esubao.Controllers.MT
{
    public class OrderController : Controller
    {
        // GET: Order    网上下单控制器
        public ActionResult Index()
        {
            return View();
        }
        //网上下单
        public ActionResult OnlineOrder()
        {
            return View();
        }
        
        [HttpPost]
 
        public string  XiaDan(Fahuo fahuo,Shouhuo shou)
        {
            EsuBaoEntities db = new EsuBaoEntities();
            DateTime dt = DateTime.Now;
            string time = dt.ToFileTime().ToString();
            string numx = "ERP" + time;
            fahuo.Express_number = numx;
            shou.Express_number = fahuo.Express_number;
            db.Fahuos.Add(fahuo);
            int fa_rs = db.SaveChanges();
            db.Shouhuos.Add(shou);
            int shou_rs = db.SaveChanges();
            string obj = "";
            if (fa_rs>0&& shou_rs>0) {
                obj = numx;
            };
            return obj;
        }
        //批量下单
        public ActionResult bulkOrder()
        {
            return View();
        }
    }
}