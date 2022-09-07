using System;
using System.Collections.Generic;

namespace Assignment1._6
{
    struct Book
    {
        int BookId;
        string Title;
        double Price;
        enum Type
        {
            MAGAZINE,
            NOVEL,
            REFERENCEBOOK,
            MISCELLANEOUS
        }
        Type BookType;

        public Book(int bookId, string Title, double Price, string BookType)
        {
            this.BookId = bookId;
            this.Title = Title;
            this.Price = Price; ;
            this.BookType = (Type)Enum.Parse(typeof(Type), BookType);
        }
        public void printDetails()
        {
            Console.WriteLine("BookId = {0}\tBook Title = {1}\tPrice of Book = {2}\tType of Book = {3}",
                    BookId, Title, Price, Enum.GetName(typeof(Type), BookType));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Book> books = new List<Book>();
            string choice;
            string cont = "Y";
            do
            {

                Console.WriteLine("Press 1 for Add Book/s\nPress 2 to Display Detials\nEnter your choice: ");
                choice = (Console.ReadLine());
                
                switch (choice)
                {
                    case "1":
                        
                        Console.WriteLine("Enter BookId : ");
                        int bookId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Book Title : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Book Price : ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Book Type : ");
                        string type = (Console.ReadLine()).ToUpper();
                        books.Add(new Book(bookId,name,price,type));
                        break;
                    case "2":
                        foreach( Book b in books)
                        {
                            b.printDetails();
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue Y/N :");
                cont = Console.ReadLine().ToUpper();
            } while (cont == "Y");
        }
    }
}
