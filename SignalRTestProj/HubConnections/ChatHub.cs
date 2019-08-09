using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRTestProj.HubConnections
{
    //HubName 这个特性是为了让客户端知道如何建立与服务器端对应服务的代理对象，
    //如果没有设定该属性，则以服务器端的服务类名字作为 HubName 的缺省值
    [HubName("chat")]
    public class ChatHub : Hub 
    {
        public void Send(string clientName, string message)
        {
            // Call the addSomeMessage method to update clients.
            Clients.All.addSomeMessage(clientName, message);
        }
    }
}