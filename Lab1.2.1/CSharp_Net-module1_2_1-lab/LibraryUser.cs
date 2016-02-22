using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    // 1) declare interface ILibraryUser
    interface ILibraryUser
    {
        void AddBook(int index);
        void RemoveBook(int index);
        string BookInfo(int index);
        int BooksCount();
    }


    // 2) declare class LibraryUser, it implements ILibraryUser
    class LibraryUser : ILibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)

        string FirstName { get; }
        string LastName { get; }
        int ID { get; }
        string Phone { get; set; }
        int BookLimit { get; }
        private static int count = 0;


        // 4) declare field (bookList) as a string array
        String[] bookList;

        // 5) declare indexer BookList for array bookList
        public string this[int index_var]
        {
            get { return bookList[index_var]; }
            set { bookList[index_var] = value; }
        }

        // 6) declare constructors: default and parameter

       public LibraryUser()
        {
            this.FirstName = "unknown";
            this.LastName = "unknown";
            this.ID = ++count;
            this.Phone = "none";
            this.BookLimit = 10;     
        }


        public LibraryUser(string FirstName, string LastName, string Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ID = ++count;
            this.Phone = Phone;
            this.BookLimit = 10;
        }

        // 7) declare methods: 
        //AddBook() – add new book to array bookList,

        //RemoveBook() – remove book from array bookList,

        //BookInfo() – returns book info by index,

        //BooksCout() – returns current count of books
        public void AddBook(int index)
        {
            this.bookList = new string[] { "1" };
        }

        public string BookInfo(int index)
        {
           // throw new NotImplementedException();
            return index + "";
        }

        public int BooksCount()
        {
            //throw new NotImplementedException();
            return this.bookList.Length;
        }

        public void RemoveBook(int index)
        {
            //throw new NotImplementedException();
        }

      
    }
}
