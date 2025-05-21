using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ChatNotification : ISendNotification
    {
        public void Send(string from, string to, string title, string body)
        {
            title = "Chat Notification";
            Console.WriteLine("------" + title + "-------");
            Console.WriteLine(to + ", you have a new chat from: " + from);
            Console.WriteLine("Tap to respond!");
        }
    }
}
