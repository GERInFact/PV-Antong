class Cow : Animal
{
    private readonly BreastFeedingComponent breastFeedingComponent = new BreastFeedingComponent();
    public void EatGrass()
    {
        Console.WriteLine("Is eating grass...");
        this.breastFeedingComponent.Feed();
    }
}