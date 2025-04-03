using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class JobTitle
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid Person2Id { get; set; }
        public Pers Pers { get; set; }
        public Guid PersId { get; set; }
    }
}
