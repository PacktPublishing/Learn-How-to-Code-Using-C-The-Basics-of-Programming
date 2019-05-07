using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLecture4
{
    class Book : IDisplay
    {
        private string title;
        private string author;
        private int numPages;

        public Book(string title, string author, int numPages)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Number of Pages: {numPages}");
        }
    }
}
