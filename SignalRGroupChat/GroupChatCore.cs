using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SignalRGroupChat
{
    public class UserContext
    {
        public UserContext()
        {
            Users = new List<User>();
            Connections = new List<Connection>();
            Rooms = new List<ConversationRoom>();
        }

        /// <summary>
        /// 用户集合
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// 连接集合
        /// </summary>
        public List<Connection> Connections { get; set; }

        /// <summary>
        /// 房间集合
        /// </summary>
        public List<ConversationRoom> Rooms { get; set; }
    }

    public class User
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Key]        
        public string UserName { get; set; }

        /// <summary>
        /// 用户的连接
        /// </summary>
        public List<Connection> Connections { get; set; }

        /// <summary>
        /// 用户房间集合
        /// </summary>
        public virtual List<ConversationRoom> Rooms { get; set; }

        public User()
        {
            Connections = new List<Connection>();
            Rooms = new List<ConversationRoom>();
        }
    }

    public class Connection
    {
        /// <summary>
        /// 连接ID
        /// </summary>
        public string ConnectionID { get; set; }

        /// <summary>
        /// 用户代理
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// 是否连接
        /// </summary>
        public bool Connected { get; set; }
    }

    /// <summary>
    /// 房间类
    /// </summary>
    public class ConversationRoom
    {
        /// <summary>
        /// 房间名称
        /// </summary>
        [Key]
        public string RoomName { get; set; }

        /// <summary>
        /// 用户集合
        /// </summary>
        public virtual List<User> Users { get; set; }

        public ConversationRoom()
        {
            Users = new List<User>();
        }
    }
}