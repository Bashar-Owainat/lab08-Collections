using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp
{
    public class Book
    {
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int numberOfPages { get; set; }



        public Book(string title, string firstName, string lastName, int numberOfPages)
        {
            this.title = title;
            this.firstName = firstName;
            this.lastName = lastName;
            this.numberOfPages = numberOfPages;
        }
    }
}
