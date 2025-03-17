using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Member
{
    public class Profesor : IMember
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Profesor(string nume, string prenume)
        {
            Nume = nume;
            Prenume = prenume;
        }

        public override string ToString()
        {
            return $"{Nume} {Prenume}";
        }
    }
}
