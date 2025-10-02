abstract class Animal
{
    public string Category { get; init; }
    public void Breath()
    {
        Console.WriteLine("Is breathing....");
    }
}

class Cow : Animal
{
    private readonly BreastFeedingComponent breastFeedingComponent = new BreastFeedingComponent();
    public void EatGrass()
    {
        Console.WriteLine("Is eating grass...");
        this.breastFeedingComponent.Feed();
    }
}

class Platypus : Animal
{
    private readonly BreastFeedingComponent _breastFeedingComponent = new BreastFeedingComponent();
    private readonly EggLayingComponent _eggLayingComponent = new EggLayingComponent();
    public void EatInsects()
    {
        Console.WriteLine("Is eating insects...");
    }
}

class EggLayingComponent
{
    public void Lay()
    {
        Console.WriteLine("Laying egg...");
    }
}

class BreastFeedingComponent
{
    public void Feed()
    {
        Console.WriteLine("Schlüüürff...");
    }
}