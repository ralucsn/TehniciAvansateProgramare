using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.Book;
using ConsoleProject.Member;

namespace ConsoleProject.System
{
    public interface IBookSystem
    {
        void AddBook(IBook book);
        void BorrowBook(IMember member, IBook book);
        void ReturnBook(IMember member, IBook book);
    }
}
