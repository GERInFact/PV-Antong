using PV.Exercises.Library;

public class Program
{
    /// <summary>
    /// The entry point of the application. Initializes and manages library operations such as adding books,
    /// renting books, and returning books while interacting with library members.
    /// </summary>
    /// <param name="args">Command-line arguments provided to the application.</param>
    public static void Main(string[] args)
    {
        var thalia = new Library();
        var harryPotter = new EBook
        {
            Author = "J.K. Rowling", Title = "Harry Potter", FileSizeInMB = 100,
            Description = "Goblet of Fire is delicious"
        };
        
        var christmasCarol = new HardcoverBook()
        {
            Author = "J.K. Rowling", Title = "Christmas Carol", PrintDate = new DateTime(1670, 12, 24),
            Description = "Very nice christmas story"
        };
        
        thalia.PopulateLibrary(harryPotter, christmasCarol);
        
        
        var anton = new Member { Id = Guid.NewGuid(), Name = "Anton Fleig" };
        
        thalia.Rent(anton, harryPotter);

        Console.WriteLine(harryPotter.EndDate);
        
        thalia.Return(anton, harryPotter);

        Console.WriteLine(harryPotter.EndDate);
    }
}