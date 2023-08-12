using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public bool IsAvailable { get; set; } = true;
}

class Author
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

class Borrower
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}

class BorrowedBook
{
    public Book Book { get; set; }
    public Borrower Borrower { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
}
class Program
{
    static List<Book> books = new List<Book>();
    static List<Author> authors = new List<Author>();
    static List<Borrower> borrowers = new List<Borrower>();
    static List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

    // ... (AddBook, UpdateBook, DeleteBook, AddAuthor, UpdateAuthor, DeleteAuthor, AddBorrower, UpdateBorrower, DeleteBorrower)

    static void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author name: ");
        string author = Console.ReadLine();
        Console.Write("Enter publication year: ");
        int publicationYear = int.Parse(Console.ReadLine());

        books.Add(new Book { Title = title, Author = author, PublicationYear = publicationYear });
        Console.WriteLine("Book added successfully.");
    }
    static void UpdateBook()
    {
        DisplayAllBooks();
        Console.Write("Enter the title of the book to update: ");
        string title = Console.ReadLine();
        Book book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        Console.WriteLine("Enter new information for the book:");
        Console.Write("New title: ");
        book.Title = Console.ReadLine();
        Console.Write("New author: ");
        book.Author = Console.ReadLine();
        Console.Write("New publication year: ");
        book.PublicationYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Book updated successfully.");
    }

    static void DeleteBook()
    {
        DisplayAllBooks();
        Console.Write("Enter the title of the book to delete: ");
        string title = Console.ReadLine();
        Book book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        books.Remove(book);
        Console.WriteLine("Book deleted successfully.");
    }


    static void AddAuthor()
    {
        Console.Write("Enter author first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter author last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter date of birth (YYYY-MM-DD): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

        authors.Add(new Author { FirstName = firstName, LastName = lastName, DateOfBirth = dateOfBirth });
        Console.WriteLine("Author added successfully.");
    }

    static void UpdateAuthor()
    {
        DisplayAllAuthors();
        Console.Write("Enter the first name of the author to update: ");
        string firstName = Console.ReadLine();
        Author author = authors.FirstOrDefault(a => a.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

        if (author == null)
        {
            Console.WriteLine("Author not found.");
            return;
        }

        Console.WriteLine("Enter new information for the Author:");
        Console.Write("New First Name: ");
        author.FirstName = Console.ReadLine();
        Console.Write("New Last Name: ");
        author.LastName = Console.ReadLine();
        Console.Write("Enter date of birth (YYYY-MM-DD): ");
        author.DateOfBirth = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Author updated successfully.");
    }

    static void DeleteAuthor()
    {
        DisplayAllAuthors();
        Console.Write("Enter the first name of the author to delete: ");
        string firstName = Console.ReadLine();
        Author author = authors.FirstOrDefault(a => a.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

        if (author == null)
        {
            Console.WriteLine("Author not found.");
            return;
        }

        authors.Remove(author);
        Console.WriteLine("Author deleted successfully.");
    }


    static void AddBorrower()
    {
        Console.Write("Enter borrower first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter borrower last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();

        borrowers.Add(new Borrower { FirstName = firstName, LastName = lastName, Email = email, PhoneNumber = phoneNumber });
        Console.WriteLine("Borrower added successfully.");
    }

    static void UpdateBorrower()
    {
        DisplayAllBorrowers();
        Console.Write("Enter the first name of the borrower to update: ");
        string firstName = Console.ReadLine();
        Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

        if (borrower == null)
        {
            Console.WriteLine("Borrower not found.");
            return;
        }

        Console.WriteLine("Enter new information for the Borrower:");
        Console.Write("New First Name: ");
        string newFirstName = Console.ReadLine();
        Console.Write("New Last Name: ");
        string newLastName = Console.ReadLine();
        Console.Write("Enter email: ");
        string newEmail = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string newPhoneNumber = Console.ReadLine();

        borrower.FirstName = newFirstName;
        borrower.LastName = newLastName;
        borrower.Email = newEmail;
        borrower.PhoneNumber = newPhoneNumber;

        Console.WriteLine("Borrower updated successfully.");
    }

    static void DeleteBorrower()
    {
        DisplayAllBorrowers();
        Console.Write("Enter the first name of the borrower to delete: ");
        string firstName = Console.ReadLine();
        Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

        if (borrower == null)
        {
            Console.WriteLine("Borrower not found.");
            return;
        }

        borrowers.Remove(borrower);
        Console.WriteLine("Borrower deleted successfully.");
    }

    static void RegisterBookToBorrower()
    {
        DisplayAllBooks();
        Console.Write("Enter book title to register: ");
        string title = Console.ReadLine();
        Book book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        DisplayAllBorrowers();
        Console.Write("Enter borrower first name: ");
        string borrowerFirstName = Console.ReadLine();
        Borrower borrower = borrowers.FirstOrDefault(b => b.FirstName.Equals(borrowerFirstName, StringComparison.OrdinalIgnoreCase));

        if (borrower == null)
        {
            Console.WriteLine("Borrower not found.");
            return;
        }

        Console.Write("Enter due date (YYYY-MM-DD): ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        borrowedBooks.Add(new BorrowedBook { Book = book, Borrower = borrower, BorrowDate = DateTime.Now, DueDate = dueDate });
        book.IsAvailable = false;
        Console.WriteLine("Book registered to borrower successfully.");
    }
    static void SearchBooks()
    {
        Console.Write("Enter search term: ");
        string searchTerm = Console.ReadLine();

        var searchResults = books.Where(b =>
            b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
            b.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
            .ToList();

        Console.WriteLine("Search Results:");
        foreach (var book in searchResults)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}, Status: {(book.IsAvailable ? "Available" : "Borrowed")}");
        }
    }

    static void FilterBooksByStatus()
    {
        Console.WriteLine("Filter Books by Status");
        Console.WriteLine("1. Available Books");
        Console.WriteLine("2. Borrowed Books");
        Console.Write("Select an option: ");
        int option = int.Parse(Console.ReadLine());

        bool status = option == 1 ? true : false;
        var filteredBooks = books.Where(b => b.IsAvailable == status).ToList();

        Console.WriteLine(option == 1 ? "Available Books:" : "Borrowed Books:");
        foreach (var book in filteredBooks)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}");
        }
    }


    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Library Management System");
            // ... (menu options)
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Update a Book");
            Console.WriteLine("3. Delete a Book");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Add Author");
            Console.WriteLine("6. Update an Author");
            Console.WriteLine("7. Delete an Author");
            Console.WriteLine("8. display All Authors");
            Console.WriteLine("9. Add Borrower");
            Console.WriteLine("10. Update a Borrower");
            Console.WriteLine("11. Delete a Borrower");
            Console.WriteLine("12. display All Borrowers");
            Console.WriteLine("13. Register Book to Borrower");
            Console.WriteLine("14. Display all Borrowed books");
            Console.WriteLine("15. Search Books");
            Console.WriteLine("16. Filter Books by Status");
            Console.WriteLine("0. Exit");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    UpdateBook();
                    break;
                case 3:
                    DeleteBook();
                    break;
                case 4:
                    DisplayAllBooks();
                    break;
                case 5:
                    AddAuthor();
                    break;
                case 6:
                    UpdateAuthor();
                    break;
                case 7:
                    DeleteAuthor();
                    break;
                case 8:
                    DisplayAllAuthors();
                    break;
                case 9:
                    AddBorrower();
                    break;
                case 10:
                    UpdateBorrower();
                    break;
                case 11:
                    DeleteBorrower();
                    break;
                case 12:
                    DisplayAllBorrowers();
                    break;
                case 13:
                    RegisterBookToBorrower();
                    break;
                case 14:
                    DisplayBorrowedBooks();
                    break;
                case 15:
                    SearchBooks();
                    break;
                case 16:
                    FilterBooksByStatus();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void DisplayAllBooks()
    {
        Console.WriteLine("All Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.PublicationYear}, Status: {(book.IsAvailable ? "Available" : "Borrowed")}");
        }
    }

    // ... (other display methods)
    static void DisplayAllAuthors()
    {
        Console.WriteLine("All Authors:");
        foreach (var author in authors)
        {
            Console.WriteLine($"Name: {author.FirstName} {author.LastName}, Date of Birth: {author.DateOfBirth:yyyy-MM-dd}");
        }
    }
    static void DisplayAllBorrowers()
    {
        Console.WriteLine("All Borrowers:");
        foreach (var borrower in borrowers)
        {
            Console.WriteLine($"Name: {borrower.FirstName} {borrower.LastName}, Email: {borrower.Email}, Phone: {borrower.PhoneNumber}");
        }
    }
    static void DisplayBorrowedBooks()
    {
        Console.WriteLine("All Borrowed Books:");
        foreach (var borrowedBook in borrowedBooks)
        {
            Console.WriteLine($"Title: {borrowedBook.Book.Title}, Author: {borrowedBook.Book.Author}");
            Console.WriteLine($"Borrower: {borrowedBook.Borrower.FirstName} {borrowedBook.Borrower.LastName}");
            Console.WriteLine($"Borrow Date: {borrowedBook.BorrowDate:yyyy-MM-dd}, Due Date: {borrowedBook.DueDate:yyyy-MM-dd}");
            Console.WriteLine();
        }
    }
}
