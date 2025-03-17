using ConsoleProject.Book;
using ConsoleProject.Member;
using ConsoleProject.System;

namespace ConsoleProject
{
    public class LibrarySystem : IBookSystem, IMemberSystem
    {
        private IBorRetProgram _borRetProgram;
        private IBookManagement _bookManagement;
        private IMemberManagement _memberManagement;

        public LibrarySystem()
        {
            _bookManagement = new BookManagement();
            _memberManagement = new MemberManagement();
            _borRetProgram = new BorRetProgram(_bookManagement, _memberManagement);
        }

        public void AddBook(IBook book)
        {
            _bookManagement.AddBook(book);
        }

        public void AddMember(IMember member)
        {
            _memberManagement.AddMember(member);
        }

        public void BorrowBook(IMember member, IBook book)
        {
            _borRetProgram.BorrowBook(member, book);
        }

        public void ReturnBook(IMember member, IBook book)
        {
            _borRetProgram.ReturnBook(member, book);
        }
    }
}
