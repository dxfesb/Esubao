using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
       //批量下单
       public ActionResult bulkOrder()
        {
            return View();
        }
    }
}