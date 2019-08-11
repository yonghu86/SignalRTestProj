using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;

namespace SignalRSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will *ONLY* bind to localhost, if you want to bind to all addresses
            // use http://*:8080 to bind to all addresses. 
            // See http://msdn.microsoft.com/en-us/library/system.net.httplistener.aspx 
            // for more information.
            string url = "http://localhost:8077";
            using (WebApp.Start(url))
            {
                Console.WriteLine("SignalR Server running on {0}", url);
                Console.ReadLine();
            }
        }
    }

    /// <summary>
    /// 该类含有SignalR服务端的配置(该教程使用的唯一的配置是用来调用UseCors), 
    /// MapSignalR为所有形式的Hub对象创建了路由规则
    /// </summary>
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }

    /// <summary>
    /// SignalR的Hub 类是程序要提供给客户端的
    /// 该类就一个方法,Send:客户端可以用来发送消息给其他客户端
    /// </summary>
    public class MyHub : Hub
    {
        //服务端的方法，客户端可以去调用
        public void Send(string name, string message)
        {
            //调用客户端的方法addMessage(string s1,string s2);      
            Clients.All.addMessage(name, message);
        }
    }
}
