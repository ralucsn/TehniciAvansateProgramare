using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.Member;

namespace ConsoleProject.Book
{
    public interface IBorRetProgram
    {
        void BorrowBook(IMember member, IBook book);
        void ReturnBook(IMember member, IBook book);
    }
}
