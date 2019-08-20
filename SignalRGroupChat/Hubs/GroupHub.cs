using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRGroupChat.Hubs
{
    /// <summary>
    /// 聊天室（群聊）
    /// </summary>
    [HubName("groupHub")]
    public class GroupHub : Hub
    {
        public static UserContext db = new UserContext();
        public void Hello()
        {
            Clients.All.hello();
        }

        /// <summary>
        /// 重写Hub连接事件
        /// </summary>
        /// <returns></returns>
        public override Task OnConnected()
        {
            // 查询用户。
            var user = db.Users.SingleOrDefault(u => u.UserName == Context.ConnectionId);

            //判断用户是否存在,否则添加
            if (user == null)
            {
                user = new User()
                {
                    UserName = Context.ConnectionId
                };
                db.Users.Add(user);
            }
            //发送房间列表
            var itme = from a in db.Rooms
                       select new { a.RoomName };
            Clients.Client(this.Context.ConnectionId).getRoomlist(JsonConvert.SerializeObject(itme.ToList()));
            return base.OnConnected();
        }

        /// <summary>
        /// 更新所有用户的房间列表
        /// </summary>
        private void GetRoomList()
        {
            var itme = from a in db.Rooms
                       select new { a.RoomName };
            string jsondata = JsonConvert.SerializeObject(itme.ToList());
            Clients.All.getRoomlist(jsondata);
        }

        // 重写Hub连接断开的事件 
        public override Task OnDisconnected(bool stopCalled)
        {
            // 查询用户 
            var user = db.Users.FirstOrDefault(u => u.UserName == Context.ConnectionId);
            if (user != null)
            {
                // 删除用户 
                db.Users.Remove(user);
                // 从房间中移除用户 
                foreach (var item in user.Rooms)
                {
                    RemoveFromRoom(item.RoomName);
                }
            }
            return base.OnDisconnected(stopCalled);
        }

        /// <summary>
        /// 加入聊天室
        /// </summary>
        /// <param name="roomName"></param>
        public void AddToRoom(string roomName)
        {
            //查询聊天室
            var room = db.Rooms.Find(a => a.RoomName == roomName);
            //存在则加入
            if (room != null)
            {
                //查找房间中是否存在此用户
                var isuser = room.Users.Where(a => a.UserName == Context.ConnectionId).FirstOrDefault();
                //不存在则加入
                if (isuser == null)
                {
                    var user = db.Users.Find(a => a.UserName == Context.ConnectionId);
                    user.Rooms.Add(room);
                    room.Users.Add(user);
                    Groups.Add(Context.ConnectionId, roomName);
                    //调用此连接用户的本地JS(显示房间)
                    Clients.Client(Context.ConnectionId).addRoom(roomName);                   
                }
                else
                {
                    Clients.Client(Context.ConnectionId).showMessage("请勿重复加入房间!");
                }
            }
        }

        /// <summary>
        /// 创建聊天室
        /// </summary>
        /// <param name="roomName"></param>
        public void CreatRoom(string roomName)
        {
            var room = db.Rooms.Find(a => a.RoomName == roomName);
            if (room == null)
            {
                ConversationRoom cr = new ConversationRoom()
                {
                    RoomName = roomName
                };
                //将房间加入列表
                db.Rooms.Add(cr);
                AddToRoom(roomName);
                Clients.Client(Context.ConnectionId).showMessage("房间创建完成!");
                GetRoomList();
            }
            else
            {
                Clients.Client(Context.ConnectionId).showMessage("房间名重复!");
            }
        }

        /// <summary>
        /// 退出聊天室
        /// </summary>
        /// <param name="roomName"></param>
        public void RemoveFromRoom(string roomName)
        {

            //查找房间是否存在
            var room = db.Rooms.Find(a => a.RoomName == roomName);
            //存在则进入删除
            if (room != null)
            {
                //查找要删除的用户
                var user = room.Users.Where(a => a.UserName == Context.ConnectionId).FirstOrDefault();
                //移除此用户
                room.Users.Remove(user);
                //如果房间人数为0,则删除房间
                if (room.Users.Count <= 0)
                {
                    db.Rooms.Remove(room);

                }
                Groups.Remove(Context.ConnectionId, roomName);
                //提示客户端
                Clients.Client(Context.ConnectionId).removeRoom("退出成功!");
            }
        }

        /// <summary>
        /// 给分组内所有的用户发送消息
        /// </summary>
        /// <param name="Room">分组名</param>
        /// <param name="Message">信息</param>
        public void SendMessage(string Room, string Message)
        {
            Clients.Group(Room, new string[0]).sendMessage(Room, Message + " " + DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}