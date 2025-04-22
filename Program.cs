using System;

namespace BookManagementApp
{
    // Define the Book class
    class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        // Constructor
        public Book(int bookId, string title, string author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
        }

        // Display method
        public void DisplayBookInfo()
        {
            Console.WriteLine("\nBook Details:");
            Console.WriteLine($"Book ID   : {BookId}");
            Console.WriteLine($"Title     : {Title}");
            Console.WriteLine($"Author    : {Author}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Input book details from user
            Console.Write("Enter Book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Book Author: ");
            string author = Console.ReadLine();

            // Create Book object
            Book book = new Book(id, title, author);

            // Display book info
            book.DisplayBookInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
