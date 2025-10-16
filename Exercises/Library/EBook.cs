namespace PV.Exercises.Library;

/// <summary>
/// Represents an electronic book in the library system. Inherits from the base Book class.
/// </summary>
public class EBook : Book
{
    public uint FileSizeInMB { get; set; }
    public override string GetBookDetails() => $"Title: {this.Title}, Author: {this.Author}";
}