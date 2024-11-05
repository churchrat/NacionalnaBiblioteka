using System.Collections;
using System.Xml.Serialization;

namespace NacionalnaBiblioteca
{
    internal class Program
    {
        static ArrayList books = new ArrayList();
        static ArrayList authors = new ArrayList();

        static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Here are your options: ");
            Console.WriteLine("To add a new book to the library: ADD");
            Console.WriteLine("To remove a book from the library: REM");
            Console.WriteLine("To search a book by name: SRC");
            Console.WriteLine("To print all books: DPS");
            Console.WriteLine("To end the progrem: END ");
            Console.WriteLine("==========================================");
            string choice = null;
            while (choice != "END")
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "ADD":
                        AddBook();
                        break;
                    case "REM":
                        RemoveBook();
                        break;
                    case "SRC":
                        SearchBook();
                        break;
                    case "DPS":
                        DisplayAllBooks();
                        break;
                    default:
                        if (choice == "END")
                        {

                        }
                        else
                        {
                            Console.WriteLine("Invalid option!!!");
                        }
                        break;
                }
                Console.WriteLine("==========================================");
            }
        }
        static void AddBook()
        {
            Console.Write("Title: ");
            books.Add(Console.ReadLine());

            Console.Write("Author: ");
            authors.Add(Console.ReadLine());
        }
        static void RemoveBook()
        {
            Console.Write("Write the name of the book you want to remove: ");
            string title = Console.ReadLine();
            if (books.Contains(title))
            {
                int index = books.IndexOf(title);
                books.RemoveAt(index);
                authors.RemoveAt(index);
                Console.WriteLine($"{title} was removed!");
            }
            else
            {
                Console.WriteLine($"A book with the name {title} doesnt exist!!!");
            }
        }

        static void SearchBook()
        {
            Console.Write("What is the title of the book your searching: ");
            string title = Console.ReadLine();

            for (int i = 0; i < books.Count; i++)
            {
                if (((string)books[i]) == title)
                {
                    Console.WriteLine($"We have {books[i]},it's author is {authors[i]},it's at index {i}");
                    break;
                }
            }
        }

        static void DisplayAllBooks()
        {
            Console.WriteLine("All books in the library:");
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Title: {books[i]}  Author: {authors[i]}");
            }
            Console.WriteLine();
        }
    }
}
