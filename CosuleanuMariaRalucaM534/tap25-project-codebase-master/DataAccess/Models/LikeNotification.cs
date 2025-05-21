using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class LikeNotification : ISendNotification
    {
        public void Send(string from, string to, string title, string body)
        {
            title = "Like Notification";
            Console.WriteLine("------" + title + "-------");
            Console.WriteLine(from + "liked your post, " + to);
            Console.WriteLine("Tap to say thank you!");
        }
    }
}
