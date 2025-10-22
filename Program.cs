var firstAttackSequence = new AbilityRunner();
firstAttackSequence.AddAbilities(new FireBall());
firstAttackSequence.AddAbilities(new AbilityDelay(new Summoner()) { DelayInSeconds = 3 });
firstAttackSequence.AddAbilities(new Defend());

var combatChain = new AbilityRunner();
combatChain.AddAbilities(new Defend());
combatChain.AddAbilities(new Summoner());
combatChain.AddAbilities(new AbilityDelay(firstAttackSequence) { DelayInSeconds = 5 });

while (true)
{
    if (Console.ReadLine() == "f")
        combatChain.Use();
}

public class AbilityRunner : IAbility
{
    private readonly IList<IAbility> abilities = new List<IAbility>(10);

    public void AddAbilities(params IEnumerable<IAbility> abilities)
    {
        foreach (var ability in abilities)
            this.abilities.Add(ability);
    }

    public void Use()
    {
        foreach (var ability in this.abilities)
            ability.Use();
    }
}

public class AbilityDelay : IAbility
{
    public int DelayInSeconds { get; set; }
    private readonly IAbility abilityToExecute;
    public AbilityDelay(IAbility ability) => this.abilityToExecute = ability;

    public void Use()
    {
        Console.WriteLine("Delayed ability in queue....");
        Task.Delay(this.DelayInSeconds * 1000).Wait();
        this.abilityToExecute.Use();
    }
}

public class Summoner : IAbility
{
    public void Use()
    {
        Console.WriteLine("Summoning");
    }
}

public class Defend : IAbility
{
    public void Use()
    {
        Console.WriteLine("Defending");
    }
}

public class FireBall : IAbility
{
    public void Use() => Console.WriteLine("Casting Fireball");
}

public interface IAbility
{
    void Use();
}