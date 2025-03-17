using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Member
{
    public class Student : IMember
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Student(string nume, string prenume)
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
