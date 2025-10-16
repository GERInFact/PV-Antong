namespace PV.Exercises.Library;

/// <summary>
/// Represents a library system where books can be stored, rented, and returned.
/// </summary>
public class Library
{
    private const int MAX_RENTAL_DAYS = 14;
    private readonly List<Book> bookStorage = new();
    private readonly Dictionary<Member, List<Book>> rentedBooks = new();

    /// <summary>
    /// Adds the specified collection of books to the library's storage.
    /// </summary>
    /// <param name="books">The books to be added to the library.</param>
    public void PopulateLibrary(params Book[] books) => this.bookStorage.AddRange(books);

    /// <summary>
    /// Rents a specified book to a member for a predefined rental period.
    /// </summary>
    /// <param name="member">The member who is renting the book.</param>
    /// <param name="book">The book that is being rented.</param>
    public void Rent(Member member, Book book)
    {
        if (!this.bookStorage.Contains(book) || member is null) return;

        if (!this.rentedBooks.ContainsKey(member))
            this.rentedBooks[member] = new();

        book.StartDate = DateTime.Now;
        book.EndDate = DateTime.Now.AddDays(MAX_RENTAL_DAYS);
        this.rentedBooks[member].Add(book);
        this.bookStorage.Remove(book);
    }

    /// <summary>
    /// Returns a rented book from a member back to the library storage.
    /// </summary>
    /// <param name="member">The member returning the book.</param>
    /// <param name="book">The book being returned.</param>
    public void Return(Member member, Book book)
    {
        if (member is null || !this.rentedBooks.ContainsKey(member) || (DateTime.Now.Subtract(book.EndDate).Days > 0)) return;


        this.bookStorage.Add(book);
        this.rentedBooks[member].Remove(book);
    }
}