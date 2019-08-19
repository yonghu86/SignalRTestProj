using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalROneToOneDemo.Connections
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class User
    {
        /// <summary>
        /// 连接ID
        /// </summary>
        [Key]
        public string ConnectionID { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        public string Name { get; set; }

        public User(string name, string connectionId)
        {
            this.Name = name;
            this.ConnectionID = connectionId;
        }
    }

    /// <summary>
    /// 点对点（一对一）聊天
    /// </summary>
    [HubName("chat")]
    public class OneToOneHub : Hub
    {
        public static List<User> users = new List<User>();

        //发送消息
        public void SendMessage(string connectionId, string message)
        {
            Clients.All.hello();
            var user = users.Where(s => s.ConnectionID == connectionId).FirstOrDefault();
            if (user != null)
            {
                Clients.Client(connectionId).addMessage(message + "" + DateTime.Now, Context.ConnectionId);
                //给自己发送，把用户的ID传给自己
                Clients.Client(Context.ConnectionId).addMessage(message + "" + DateTime.Now, connectionId);
            }
            else
            {
                Clients.Client(Context.ConnectionId).showMessage("该用户已离线...");
            }
        }

        [HubMethodName("getName")]
        public void GetName(string name)
        {
            //查询用户
            var user = users.SingleOrDefault(u => u.ConnectionID == Context.ConnectionId);
            if (user != null)
            {
                user.Name = name;
                Clients.Client(Context.ConnectionId).showId(Context.ConnectionId);
            }
            GetUsers();
        }

        /// <summary>
        /// 重写连接事件
        /// </summary>
        /// <returns></returns>
        public override Task OnConnected()
        {
            //查询用户
            var user = users.Where(u => u.ConnectionID == Context.ConnectionId).SingleOrDefault();
            //判断用户是否存在，否则添加集合
            if (user == null)
            {
                user = new User("", Context.ConnectionId);
                users.Add(user);
            }
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var user = users.Where(p => p.ConnectionID == Context.ConnectionId).FirstOrDefault();
            //判断用户是否存在，存在则删除
            if (user != null)
            {
                //删除用户
                users.Remove(user);
            }
            GetUsers();//获取所有用户的列表
            return base.OnDisconnected(stopCalled);
        }

        //获取所有用户在线列表
        private void GetUsers()
        {
            var list = users.Select(s => new { s.Name, s.ConnectionID }).ToList();
            string jsonList = JsonConvert.SerializeObject(list);
            Clients.All.getUsers(jsonList);
        }
    }
}