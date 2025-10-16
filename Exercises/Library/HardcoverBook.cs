namespace PV.Exercises.Library;

/// <summary>
/// Represents a hardcover book in the library system, inheriting from the base Book class.
/// </summary>
public class HardcoverBook : Book
{
    public DateTime PrintDate { get; set; }

    public override string GetBookDetails() =>
        $"Title: {this.Title}, Author: {this.Author} Date of printing: {this.PrintDate}";
}