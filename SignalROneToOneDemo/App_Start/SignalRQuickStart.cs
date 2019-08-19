using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalROneToOneDemo.App_Start.SignalRQuickStart))]

namespace SignalROneToOneDemo.App_Start
{
    public class SignalRQuickStart
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
            // 配置集线器
            app.MapSignalR();
        }
    }
}
