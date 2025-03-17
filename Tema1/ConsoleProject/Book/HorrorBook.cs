using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Book
{
    public class HorrorBook : IBook
    {
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public HorrorBook(string titlu, string autor)
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
