using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRTestProj.Controllers
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

        public ActionResult SignalRPersistentConnectionsDemo()
        {
            ViewBag.Message = "SignalR永久连接类 Demo";
            return View();
        }

        public ActionResult HubChat()
        {
            ViewBag.ClientName = "用户-" + Guid.NewGuid().ToString().Substring(1,6);
            return View();
        }
    }
}