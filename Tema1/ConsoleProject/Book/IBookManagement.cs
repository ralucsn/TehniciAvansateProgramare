using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Book
{
    internal interface IBookManagement
    {
        void AddBook(IBook book);
        void RemoveBook(IBook book);
        bool ContainsBook(IBook book);
    }
}
