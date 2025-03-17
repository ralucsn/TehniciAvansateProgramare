using ConsoleProject.Book;
using ConsoleProject.Member;

namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");

            LibrarySystem library = new LibrarySystem();


            //definesc pentru inceput:
            //2 carti
            IBook book1 = new HorrorBook("Dracula", "Bram Stoker");
            IBook book2 = new RomanceBook("Pride and Prejudice", "Jane Austen");
            
            //2 membri
            IMember member1 = new Profesor("Rusu", "Iulian");
            IMember member2 = new Student("Cosuleanu", "Raluca");

            //adaug cartile
            library.AddBook(book1);
            library.AddBook(book2);

            //adaug membrii
            library.AddMember(member1);
            library.AddMember(member2);

            //arat niste imprumuturi si returnari de carti
            library.BorrowBook(member1, book1);
            library.ReturnBook(member1, book1);

            library.BorrowBook(member2, book2);
            library.ReturnBook(member2, book2);
        }
    }
}
