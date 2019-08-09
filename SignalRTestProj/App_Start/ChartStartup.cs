using Microsoft.Owin;
using Owin;
using SignalRTestProj.Connections;

[assembly: OwinStartup(typeof(SignalRTestProj.App_Start.ChartStartup))]

namespace SignalRTestProj.App_Start
{
    public class ChartStartup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
            // 配置上文实现的ChatConnections
            app.MapSignalR<ChatConnection>("/Connections/ChatConnection");
        }
    }
}
