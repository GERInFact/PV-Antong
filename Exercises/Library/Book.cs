namespace PV.Exercises.Library;

/// <summary>
/// Represents the base class for a book in the library system.
/// </summary>
public abstract class Book
{
    public Guid Isbn { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public abstract string GetBookDetails();
}