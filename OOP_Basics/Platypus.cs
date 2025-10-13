class Platypus : Animal
{
    private readonly BreastFeedingComponent _breastFeedingComponent = new BreastFeedingComponent();
    private readonly EggLayingComponent _eggLayingComponent = new EggLayingComponent();
    public void EatInsects()
    {
        Console.WriteLine("Is eating insects...");
    }
}