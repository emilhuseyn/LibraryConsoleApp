using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rever
{
    public class BookOperations
    {
        public Book AddBook()
        {
            Console.WriteLine("Please enter the title");
            string Title=Console.ReadLine();
            Console.WriteLine("Please enter the AuthorName");
            string AuthorName = Console.ReadLine();
            Console.WriteLine("Please enter the Genre");
            string Genre = Console.ReadLine();
            Console.WriteLine("Please enter the Page Count");
            int PageCount = Convert.ToInt32(Console.ReadLine());
            Book book=new Book();
            book.AuthorName = AuthorName;
            book.Title = Title;
            book.Genre = Genre;
            book.PageCount = PageCount;
            return book;
        }
        public void ShowBooks(Book[] books)
        {
            if (books.Length == 0)
            {
                Console.WriteLine("There is no book you added");
            }
            else
            {
                for (int i = 0; i < books.Length; i++)
                {
                    Console.WriteLine($"Book:{i + 1}");
                    Console.WriteLine(books[i].Title);
                    Console.WriteLine(books[i].AuthorName);
                    Console.WriteLine(books[i].Genre);
                    Console.WriteLine(books[i].PageCount);
                    Console.WriteLine();
                }
            }
        }
    }
}
