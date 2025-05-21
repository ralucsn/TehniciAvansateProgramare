using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class User : Account
    {
        public int UserId { get; set; } = new Random().Next(1, 1000);
        public string Username { get; set; }
        public string Email { get; set; }



        public List<ChatNotification> Chats { get; set; }
        public List<LikeNotification> Likes { get; set; }
        public List<Post> Posts { get; set; }


        public override bool createAccount()
        {
            return true;
        }
    }
}