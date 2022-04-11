using System;
using System.Collections.Generic;

namespace CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EnteredBooks();

            UserInterface();

            
        }


        static Library library = new Library();
        static Backpack<Book> Bag = new Backpack<Book>();
        public static void EnteredBooks()
        {

            library.Add("History", "Chris", "Fallan", 200);
            library.Add("BOOK2", "Mike", "Fallan", 450);
            library.Add("Book3", "John", "Fallan", 300);
            library.Add("Book4", "Tom", "Fallan", 150);

        }

        public static void UserInterface()
        {
            
            Console.WriteLine("Welcome to Our library");
            Console.WriteLine("Please select an action: ");
            Console.WriteLine("1- View Books ");
            Console.WriteLine("2- Add a Book ");
            Console.WriteLine("3- Borrow a book ");
            Console.WriteLine("4- Return a book ");
            Console.WriteLine("5- View Borrowed books ");
            Console.WriteLine("6- Exit ");

            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    ViewBooks();
                    break;
                case 2:
                    AddBook();
                    break;
                case 3:
                    BorrowBook();
                    break;
                case 4:
                    ReturnBook();
                    break;
                case 5:
                    VeiwBorrowedBooks();
                    break;
                case 6:
                    Console.WriteLine("Thank you for using our library");
                    break;
                
            }

        }

        public static void ReturnBook()
        {
            Console.WriteLine("Please select the number of the book you want to return to the library");
            Dictionary<int, Book> books = new Dictionary<int, Book>();
            int counter = 0;
          
            foreach (Book book in Bag)
            {
                books.Add(counter, book);
                Console.WriteLine("Index : " + counter + " Tile: " + book.title + " Author: " + book.firstName + " " + book.lastName);
                counter++;
            }
           
            int userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput > counter)
            {
                throw new Exception();
            }
            Book book1 = Bag.Unpack(userInput);
            library.Return(book1);
            UserInterface();
        }
        public static void VeiwBorrowedBooks()
        {
            int counter = 0;
            foreach (Book book in Bag)
            {
                Console.WriteLine( "Index : " +counter + "Tile: " + book.title + " Author: " + book.firstName + " " + book.lastName);
                counter++;
            }
            UserInterface();
            //return counter;
        }
        public static void BorrowBook()
        {
            foreach (Book book in library)
            {
                Console.WriteLine("Tile: " + book.title + " Author: " + book.firstName + " " + book.lastName);
            }
            Console.WriteLine("Enter the title you want to borrow");

            string userInput = Console.ReadLine();
            
            Book borrowed = library.Borrow(userInput.ToUpper());

            Bag.Pack(borrowed);
            UserInterface();
        }
        public static void AddBook()
        {
            Console.WriteLine("Please enter a title for your book");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter the first name of the author");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of the author");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter the number of pages ");
            int numOfPages = Convert.ToInt32(Console.ReadLine());

            library.Add(title.ToUpper(), firstName.ToUpper(), lastName.ToUpper(), numOfPages);
            UserInterface();
        }
        public static void ViewBooks()
        {
            foreach(Book book in library)
            {
                Console.WriteLine("Tile: "+book.title + " Author: "+ book.firstName+ " " +book.lastName);
            }
            UserInterface();
        } 


    }
   
   
}
