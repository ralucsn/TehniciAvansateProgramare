using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Angajat
    {
        public Angajat()
        {

        }

        public Angajat(string nume)
        {
            Name = nume;
        }

        public Angajat(string id, string nume)
        {
            Id = new Guid(id);
            Name = nume;
            Responsabilities = new List<Responsabilities>();
        }

        public Guid Id {  get; set; }
        public string Name { get; set; }
        public ICollection<Responsabilities> Responsabilities {  get; set; }
    }
}
