using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class BookContainer
    {
        public List<Book> SortByName(List<Book> books)
        {
            for(int i = 0; i < books.Count; i++)
            {
                for(int j = 0; j < books.Count; j++)
                {
                    if(books[i].Name == books[j].Name)
                    {

                    }
                }
            }
            return 
        }
        public List<Book> SortByAuthor(List<Book> books)
        {
            return books.OrderBy(book => book.Author).ToList();
        }
        public List<Book> SortByPublish(List<Book> books)
        {
            return books.OrderBy(book => book.Publisher).ToList();
        }
    }
}
