using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class IdCard
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
