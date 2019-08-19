using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalROneToOneDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// 一对一（点对点）聊天
        /// </summary>
        /// <returns></returns>
        public ActionResult OneToOneChat()
        {
            ViewBag.Message = "一对一（点对点）聊天";
            return View();
        }
        
    }
}