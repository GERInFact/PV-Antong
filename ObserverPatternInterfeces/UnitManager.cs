namespace PV.ObserverPatternInterfeces;


public class UnitManager
{
    public event Action OnCommandIssued = () => {};
    
    public void Command()
    {
        Console.WriteLine("Command is being issued....");
        this.OnCommandIssued();
    }
    
}