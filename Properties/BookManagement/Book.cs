using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class Book
    {
        private string _isbn;
        private string _title;
        private string _author;
        private int _pages;

        public Book()
        {
            _isbn = string.Empty;
            _title = string.Empty;
            _author = string.Empty;
            _pages = 0;
        }

        public string ISBN { get { return _isbn; } set { _isbn = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public int Pages { get { return _pages; } set { _pages = value; } }
    }
}
