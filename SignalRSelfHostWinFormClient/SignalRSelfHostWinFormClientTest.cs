using Microsoft.AspNet.SignalR.Client;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace SignalRSelfHostWinFormClient
{
    /// <summary>
    /// SignalRSelfHost WinForm测试客户端
    /// 用于接收消息（需配合SignalRSelfHostJSClient项目使用）
    /// </summary>
    public partial class SignalRSelfHostWinFormClientTest : Form
    {
        //定义代理,广播服务连接相关
        private static IHubProxy HubProxy { get; set; }
        private static readonly string ServerUrl = ConfigurationManager.AppSettings["SignalRServer"];
        //定义一个连接对象
        public static HubConnection Connection { get; set; }

        public SignalRSelfHostWinFormClientTest()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void SignalRSelfHostWinFormClientTest_Load(object sender, EventArgs e)
        {
            Connection = new HubConnection(ServerUrl);            
            Connection.Closed += Connection_Closed;
            HubProxy = Connection.CreateHubProxy("MyHub");
            HubProxy.On<string, string>("addMessage", RecvMsg);//接收实时信息
            Connection.Start().ContinueWith(task =>
            {
                if (!task.IsFaulted)
                {
                    msgContent.AppendText(string.Format("与Signal服务器连接成功,服务器地址：{0}\r\n",ServerUrl));
                }
                else
                {
                    msgContent.AppendText("与服务器连接失败，请确认服务器是否开启。\r\n");
                }
            }).Wait();
        }

        private void Connection_Closed()
        {
            msgContent.AppendText("连接关闭...\r\n");
        }

        private void RecvMsg(string name, string message)
        {
            msgContent.AppendText(string.Format("接收时间：{0},发送人：{1},消息内容：{2}，\r\n", DateTime.Now, name, message));          
        }
    }
}
