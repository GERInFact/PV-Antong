using PV.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        var player = new Player{Weaponizable = new Tower()};
        player.Attack();
    }
}

public class Tower : IWeaponizable
{
    public void Use()
    {
        Console.WriteLine("Tower explodes and kills all enemies in the area");
    }
}

public class MightyThorHammer : IWeaponizable
{
    public void Use()
    {
        Console.WriteLine("Thors Hammer");
    }
}