using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.Member;

namespace ConsoleProject.Book
{
    internal class BorRetProgram:IBorRetProgram
    {
        private IBookManagement _bookManagement;
        private IMemberManagement _memberManagement;

        public BorRetProgram(IBookManagement bookManagement, IMemberManagement memberManagement)
        {
            _bookManagement = bookManagement;
            _memberManagement = memberManagement;
        }

        public void BorrowBook(IMember member, IBook book)
        {
            if (_bookManagement.ContainsBook(book) && _memberManagement.ContainsMember(member))
            {
                _bookManagement.RemoveBook(book);
                Console.WriteLine($"{member} borrowed {book}");
            }
            else
            {
                Console.WriteLine("Book or member not found.");
            }
        }

        public void ReturnBook(IMember member, IBook book)
        {
            _bookManagement.AddBook(book);
            Console.WriteLine($"{member} returned {book}");
        }
    }
}
