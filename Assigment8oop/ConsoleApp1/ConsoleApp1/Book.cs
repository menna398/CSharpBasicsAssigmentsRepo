using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        // Default constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
        }

        // Constructor with Title
        public Book(string title)
        {
            Title = title;
            Author = "Unknown";
        }

        // Constructor with Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
