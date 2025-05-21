using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ModelDTOs
{
    public class UserDTO
    {
        public int UserId { get; set; } = new Random().Next(1, 1000);
        public string Username { get; set; }
        public string Email { get; set; }

    }
}
