using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Book
{
    public class RomanceBook : IBook
    {
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public RomanceBook(string titlu, string autor)
        {
            Titlu = titlu;
            Autor = autor;
        }

        public override string ToString()
        {
            return $"{Titlu}, {Autor}";
        }
    }
}
