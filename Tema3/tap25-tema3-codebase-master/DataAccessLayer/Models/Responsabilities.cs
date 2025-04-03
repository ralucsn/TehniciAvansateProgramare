using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Responsabilities
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public ICollection<Angajat> Angajati { get; set; }
    }
}
