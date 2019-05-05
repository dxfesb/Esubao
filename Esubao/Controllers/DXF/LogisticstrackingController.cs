using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

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
        public JsonResult wLselect()
        {
            string appkey = "bbf73fc9816a0a465577b42dd80f7d9b"; //配置您申请的appkey


            //1.常用快递查询API
            string url1 = "http://v.juhe.cn/exp/index";

            var parameters1 = new Dictionary<string, string>();

            parameters1.Add("com", ""); //需要查询的快递公司编号
            parameters1.Add("no", ""); //需要查询的订单号
            parameters1.Add("key", "bbf73fc9816a0a465577b42dd80f7d9b");//你申请的key
            parameters1.Add("dtype", ""); //返回数据的格式,xml或json，默认json

            string result1 = sendPost(url1, parameters1, "get");

            Root newObj1 = new Root();
            String errorCode1 = newObj1["error_code"].Value;

            if (errorCode1 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj1);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj1["error_code"].Value + ":" + newObj1["reason"].Value);
            }


            //2.快递公司编号对照表
            string url2 = "http://v.juhe.cn/exp/com";

            var parameters2 = new Dictionary<string, string>();


            string result2 = sendPost(url2, parameters2, "get");

            JsonObject newObj2 = new JsonObject(result2);
            String errorCode2 = newObj2["error_code"].Value;

            if (errorCode2 == "0")
            {
                Debug.WriteLine("成功");
                Debug.WriteLine(newObj2);
            }
            else
            {
                //Debug.WriteLine("失败");
                Debug.WriteLine(newObj2["error_code"].Value + ":" + newObj2["reason"].Value);
            }


        }

        /// <summary>
        /// Http (GET/POST)
        /// </summary>
        /// <param name="url">请求URL</param>
        /// <param name="parameters">请求参数</param>
        /// <param name="method">请求方法</param>
        /// <returns>响应内容</returns>
        static string sendPost(string url, IDictionary<string, string> parameters, string method)
        {
            if (method.ToLower() == "post")
            {
                HttpWebRequest req = null;
                HttpWebResponse rsp = null;
                System.IO.Stream reqStream = null;
                try
                {
                    req = (HttpWebRequest)WebRequest.Create(url);
                    req.Method = method;
                    req.KeepAlive = false;
                    req.ProtocolVersion = HttpVersion.Version10;
                    req.Timeout = 5000;
                    req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
                    byte[] postData = Encoding.UTF8.GetBytes(BuildQuery(parameters, "utf8"));
                    reqStream = req.GetRequestStream();
                    reqStream.Write(postData, 0, postData.Length);
                    rsp = (HttpWebResponse)req.GetResponse();
                    Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
                    return GetResponseAsString(rsp, encoding);
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    if (reqStream != null) reqStream.Close();
                    if (rsp != null) rsp.Close();
                }
            }
            else
            {
                //创建请求
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "?" + BuildQuery(parameters, "utf8"));

                //GET请求
                request.Method = "GET";
                request.ReadWriteTimeout = 5000;
                request.ContentType = "text/html;charset=UTF-8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

                //返回内容
                string retString = myStreamReader.ReadToEnd();
                return retString;
            }
        }

        /// <summary>
        /// 组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <returns>URL编码后的请求数据</returns>
        static string BuildQuery(IDictionary<string, string> parameters, string encode)
        {
            StringBuilder postData = new StringBuilder();
            bool hasParam = false;
            IEnumerator<KeyValuePair<string, string>> dem = parameters.GetEnumerator();
            while (dem.MoveNext())
            {
                string name = dem.Current.Key;
                string value = dem.Current.Value;
                // 忽略参数名或参数值为空的参数
                if (!string.IsNullOrEmpty(name))//&& !string.IsNullOrEmpty(value)
                {
                    if (hasParam)
                    {
                        postData.Append("&");
                    }
                    postData.Append(name);
                    postData.Append("=");
                    if (encode == "gb2312")
                    {
                        postData.Append(HttpUtility.UrlEncode(value, Encoding.GetEncoding("gb2312")));
                    }
                    else if (encode == "utf8")
                    {
                        postData.Append(HttpUtility.UrlEncode(value, Encoding.UTF8));
                    }
                    else
                    {
                        postData.Append(value);
                    }
                    hasParam = true;
                }
            }
            return postData.ToString();
        }

        /// <summary>
        /// 把响应流转换为文本。
        /// </summary>
        /// <param name="rsp">响应流对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>响应文本</returns>
        static string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            System.IO.Stream stream = null;
            StreamReader reader = null;
            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }
        public class ListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string datetime { get; set; }
            /// <summary>
            /// 离开郴州市 发往长沙市【郴州市】
            /// </summary>
            public string remark { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string zone { get; set; }
        }

        public class Result
        {
            /// <summary>
            /// 
            /// </summary>
            public string company { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string com { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string no { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string status_detail { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ListItem> list { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public string resultcode { get; set; }
            /// <summary>
            /// 查询物流信息成功
            /// </summary>
            public string reason { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Result result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int error_code { get; set; }
        }
    }
}