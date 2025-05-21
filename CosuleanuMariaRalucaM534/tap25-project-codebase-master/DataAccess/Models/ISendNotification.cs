using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public interface ISendNotification
    {
        void Send(string from, string to, string title, string body);
    }
}
