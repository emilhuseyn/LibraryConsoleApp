using System;

namespace Rever
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Book[] books = new Book[0];
            BookOperations bookOperations = new BookOperations();
            Console.WriteLine("Welcome to library");
            while (true)
            {
                Console.WriteLine("Please select an operation");
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Show Books");
                Console.WriteLine("0.Exit library");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thanks");
                        return;
                    case 1:
                        Array.Resize(ref books,books.Length+1);
                        books[books.Length - 1] = bookOperations.AddBook();                        
                        break;
                    case 2:
                        bookOperations.ShowBooks(books);
                        break;
                    default:
                        Console.WriteLine("Please enter the correct value");
                        break;

                }
            }
        }
    }

}
