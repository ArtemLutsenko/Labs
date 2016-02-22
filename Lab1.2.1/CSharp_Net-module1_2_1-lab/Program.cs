using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    abstract class Cl
    {
        public string str;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 8) declare 2 objects. Use default and paremeter constructors

            LibraryUser user1 = new LibraryUser("Artem","Lutsenko", "000000");
            LibraryUser user2 = new LibraryUser();

           

            // 9) do operations with books for all users: run all methods for both objects
            user1.AddBook(1);
            user1.BookInfo(1);
            user1.BooksCount();
            user1.RemoveBook(1);

            user2.AddBook(1);
            user2.BookInfo(1);
            user2.BooksCount();
            user2.RemoveBook(1);

        }
    }
}
