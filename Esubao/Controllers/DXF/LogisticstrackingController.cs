using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Esubao.Controllers.DXF
{
    public class LogisticstrackingController : Controller
    {
        // GET: Logisticstracking
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logisticstrakcing()
        {
            return View();
        }
        public ActionResult PriceTime()
        {
            return View();
        }
        /// <summary>
        /// 物流查询接口调用及物流查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }
        private const String host = "http://kdwlcxf.market.alicloudapi.com";
        private const String path = "/kdwlcx";
        private const String method = "GET";
        private const String appcode = "7bd384351740479f9b35be67763bbc5d";
        [HttpPost]
        public JsonResult WLselect(string number) {  
            String querys = "no="+number+"";
            String bodys = "";
            String url = host + path;
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;

            if (0 < querys.Length)
            {
                url = url + "?" + querys;
            }

            if (host.Contains("http://"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
            }
            httpRequest.Method = method;
            httpRequest.Headers.Add("Authorization", "APPCODE " + appcode);
            if (0 < bodys.Length)
            {
                byte[] data = Encoding.UTF8.GetBytes(bodys);
                using (Stream stream = httpRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            try
            {
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (WebException ex)
            {
                httpResponse = (HttpWebResponse)ex.Response;
            }
            Console.WriteLine(httpResponse.StatusCode);
            Console.WriteLine(httpResponse.Method);
            Console.WriteLine(httpResponse.Headers);
            using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
            {
                var respContene = reader.ReadToEnd();
                return Json( respContene);
            }  
        }      

    }
    }