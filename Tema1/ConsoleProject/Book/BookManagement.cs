using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Book
{
    public class BookManagement:IBookManagement
    {
        private List<IBook> _books = new();

        public void AddBook(IBook book)
        {
            _books.Add(book);
        }
        public void RemoveBook(IBook book)
        {
            _books.Remove(book);
        }

        public bool ContainsBook(IBook book)
        {
            return _books.Contains(book);
        }
    }
}
