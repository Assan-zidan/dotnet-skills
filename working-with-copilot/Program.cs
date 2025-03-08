using System;

class Program
{
    static string[] books = new string[5]; // Array to store up to 5 books

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Remove a Book");
            Console.WriteLine("3. Display Books");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    RemoveBook();
                    break;
                case "3":
                    DisplayBooks();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter the title of the book to add: ");
        string title = Console.ReadLine();

        for (int i = 0; i < books.Length; i++)
        {
            if (string.IsNullOrEmpty(books[i]))
            {
                books[i] = title;
                Console.WriteLine($"Book '{title}' added successfully.");
                return;
            }
        }

        Console.WriteLine("The library is full. Cannot add more books.");
    }

    static void RemoveBook()
    {
        Console.Write("Enter the title of the book to remove: ");
        string title = Console.ReadLine();

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == title)
            {
                books[i] = string.Empty; // Clear the slot
                Console.WriteLine($"Book '{title}' removed successfully.");
                return;
            }
        }

        Console.WriteLine($"Book '{title}' not found in the library.");
    }

    static void DisplayBooks()
    {
        Console.WriteLine("\nCurrent List of Books:");
        bool isEmpty = true;

        for (int i = 0; i < books.Length; i++)
        {
            if (!string.IsNullOrEmpty(books[i]))
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
                isEmpty = false;
            }
        }

        if (isEmpty)
        {
            Console.WriteLine("The library is empty.");
        }
    }
}