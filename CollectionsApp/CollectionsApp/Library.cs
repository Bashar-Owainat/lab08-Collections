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
        

        private Dictionary<string, Book> Allbooks = new Dictionary<string, Book>();

       

        public int Count => Allbooks.Count;




        // Add a Book to the library.
        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {

            Book book = new Book(title, firstName, lastName, numberOfPages);
            Allbooks.Add(title, book);

        }


        // Remove a Book from the library with the given title.
        // <returns>The Book, or null if not found.</returns>
        public Book Borrow(string title)
        {


            if (Allbooks.ContainsKey(title))
            {
                Book book = Allbooks[title];
                Allbooks.Remove(title);
                
                return book;
            }
            else
            {
                return null;

            }
        
        }

        // Return a Book to the library.
        public void Return(Book book)
        {
            Allbooks.Add(book.title, book);

        }

        
        public IEnumerator<Book> GetEnumerator()
        {
            foreach ( Book book in Allbooks.Values)
            {
                yield return book;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
