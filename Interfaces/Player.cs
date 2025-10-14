namespace PV.Interfaces;

public class Player
{
    public IWeaponizable Weaponizable { get; set; }
    public void Attack()
    {
        if(this.Weaponizable is null) return;
        
        this.Weaponizable.Use();
    }
}

public interface IWeaponizable 
{
    void Use();
}

public class Bow : IWeaponizable
{
    public int  ArrowCount { get; set; }
    private void Shoot()
    {
        Console.WriteLine("Boom Bow");
    }

    public void Use()
    {
        this.Shoot();
    }
}

public class Sword : IWeaponizable
{
    public int Durability { get; set; }
    private void Slay(string target)
    {
        Console.WriteLine("Killing " + target + "");
    }

    public void Use()
    {
        this.Slay("Zombie");   
    }
}


public class MagicWand : IWeaponizable
{
    public int MaicPower { get; set; }
    public void Cast()
    {
        Console.WriteLine("Magic Wand");
    }

    public void Use()
    {
        this.Cast();
    }
}