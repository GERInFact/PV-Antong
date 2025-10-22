namespace PV.ObserverPatternInterfeces;


public class Solider
{
    public void Advance()
    {
        Console.WriteLine("Soldier is claiming territory...");
    }
}

public class Drone
{
    public void FlyAndSeek()
    {
        Console.WriteLine("Drone is seeking for stuff...");
    }
}

public class CommunicationTower
{
    public void IssueWarning()
    {
        Console.WriteLine("CommunicationTower has detected stuff...");
    }
}

public class HackerControlHub
{
    public void StartDDosAttack()
    {
        Console.WriteLine("DDos.....");
    }

}