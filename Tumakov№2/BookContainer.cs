using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class BookContainer
    {
        public static List<Book> SortName(List<Book> books)
        {
            for(int i = 0; i < books.Count; i++)
            {
                for(int j = 0; j < books.Count; j++)
                {
                    if ((books[i].Name)[0] > (books[j].Name)[0])
                    {
                        string x = (books[i].Name);
                        books[i].Name = books[j].Name;
                        books[j].Name = x;
                    }
                }
            }
            return books;
        }
        public static List<Book> SortAuthor(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                for (int j = 0; j < books.Count; j++)
                {
                    if ((books[i].Author)[0] > (books[j].Author)[0])
                    {
                        string x = (books[i].Author);
                        books[i].Author = books[j].Author;
                        books[j].Author = x;
                    }
                }
            }
            return books;
        }
        public static List<Book> SortPublish(List<Book> books)
        {
            for (int i = 0; i < books.Count; i++)
            {
                for (int j = 0; j < books.Count; j++)
                {
                    if ((books[i].Publisher)[0] > (books[j].Publisher)[0])
                    {
                        string x = (books[i].Publisher);
                        books[i].Publisher = books[j].Publisher;
                        books[j].Publisher = x;
                    }
                }
            }
            return books;
        }

    }
}

