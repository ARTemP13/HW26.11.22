using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public Book(string name, string author, string publisher)
        {
            Author = author;
            Name = name;
            Publisher = publisher;
        }
        
    }
}
