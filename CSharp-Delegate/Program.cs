using System;
using ClassLibrary;
namespace CSharp_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();

            book1.Name = "salam";
            book2.Name = "sagol";
            book3.Name = "necesen";

            book1.Genre = GenreEnum.dedective;
            book2.Genre = GenreEnum.science;
            book3.Genre = GenreEnum.dedective;

            book1.Price = 100;
            book2.Price = 200;
            book3.Price = 300;

            Library library = new Library();

            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);
            Console.WriteLine("==========All Books==========");
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("==========Filter by Genre==========");
            foreach (var item in library.FilterByGenre(GenreEnum.dedective))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("==========Filter by Price==========");
            foreach (var item in library.FilterByPrice(99,299))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("==========Filter by No==========");
            Console.WriteLine(library.FindBookByNo(2).Name);

            Console.WriteLine("==========Is Exist by No==========");
            Console.WriteLine(library.isExistBookByNo(4));

            Console.WriteLine("==========Remove Item==========");
            library.RemoveAll(x => x.Name.Length < 6);
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }
            
        }
    }
}
