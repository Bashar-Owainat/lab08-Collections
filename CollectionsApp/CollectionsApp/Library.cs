using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp
{
    public class Library : ILibrary
    {
        

        private Dictionary<string, Book> books = new Dictionary<string, Book>();

        int IReadOnlyCollection<Book>.Count => throw new NotImplementedException();




        // Add a Book to the library.
        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {

            Book book = new Book(title, firstName, lastName, numberOfPages);
            books.Add(title, book);

        }


        // Remove a Book from the library with the given title.
        // <returns>The Book, or null if not found.</returns>
        public Book Borrow(string title)
        {


            if (books.ContainsKey(title))
            {
                books.Remove(title);
                return books[title];
            }
            else
            {
                return null;

            }
        
        }

        // Return a Book to the library.
        public void Return(Book book)
        {
            books.Add(book.title, book);

        }


        public IEnumerator<Book> GetEnumerator()
        {
            //  return (IEnumerator<Book>)(books);

            return null;
            

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
