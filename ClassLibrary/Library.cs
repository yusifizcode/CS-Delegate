using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Book> FilterByPrice(int min, int max)
        {
            List<Book> books = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Price>min && item.Price<max)
                {
                    books.Add(item);
                }
            }
            return books;
        }
        public List<Book> FilterByGenre(GenreEnum genre)
        {
            List<Book> books = new List<Book>();
            foreach (var item in Books)
            {
                if (item.Genre==genre)
                {
                    books.Add(item);
                }
            }
            return books;
        }
        public Book FindBookByNo(int no)
        {
            foreach (var item in Books)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            return null;
        }
        public bool isExistBookByNo(int no)
        {
            foreach (var item in Books)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Book> RemoveAll(Predicate<Book> predicate)
        {
            List<Book> books = new List<Book> ();
            foreach (var item in Books)
            {
                if (predicate(item))
                {
                    books.Add(item);
                }
            }
            Books = books;
            return Books;
        }
    }
}
