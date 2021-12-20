using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;
        public Book(string _title, string _author, int _pages)
        {
            this.title = _title;
            this.author = _author;
            this.pages = _pages;
        }
        public void PrintBook()
        {
            Console.WriteLine($"title: {this.title} author: {this.author} pages: {this.pages}");
        }
    }
}
