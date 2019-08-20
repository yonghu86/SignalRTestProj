using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRGroupChat.Controllers
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
        /// 聊天室（群聊）
        /// </summary>
        /// <returns></returns>
        public ActionResult GroupChat()
        {
            ViewBag.Message = "聊天室（群聊）";
            return View();
        }
    }
}