using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esubao.Models
{
    public class Infor
    {
        public class ListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string time { get; set; }
            /// <summary>
            /// [成都市/资阳市/眉山市]已签收
            /// </summary>
            public string status { get; set; }
        }

        public class Result
        {
            /// <summary>
            /// 
            /// </summary>
            public string number { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ListItem> list { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string deliverystatus { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string issign { get; set; }
            /// <summary>
            /// 顺丰快递
            /// </summary>
            public string expName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string expSite { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string expPhone { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string logo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string courier { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string courierPhone { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public string status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string msg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Result result { get; set; }
        }
    }
}