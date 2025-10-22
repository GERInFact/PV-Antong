Console.WriteLine("Hello, World!");
var ai = new TerroristAI();

while(true)
    ai.Act();


public interface IState
{
    void Tick();
}

class TerroristAI : IStateContext
{
    private IState _state;

    public TerroristAI() => this._state = new SeekState(this) {DetectionRadius = 12.2f};
    public void SetState(IState state) => this._state = state;
    
    public void Act() => this._state.Tick();
}

public interface IStateContext
{
    void SetState(IState state);
}

public class SeekState : IState
{
    public float DetectionRadius { get; set; }

    private readonly IStateContext _context;
    public SeekState(IStateContext context) => _context = context;

    public void Tick()
    {
        Console.WriteLine($"Seeking for stuff... Nothing detected yet in ...{this.DetectionRadius}m");
        this.TryTriggerStateChange();
    }

    private void TryTriggerStateChange()
    {
        if (Console.ReadLine() == "a")
            this._context.SetState(new AttackState(this._context) {Attacks = 3});
        else if (Console.ReadLine() == "p")
            this._context.SetState(new PatrolState(this._context));
        else
            Console.WriteLine("Nothing to trigger....");
    }
}

public class AttackState : IState
{
    public int Attacks { get; set; }
    private readonly IStateContext _context;
    public AttackState(IStateContext context) => _context = context;

    public void Tick()
    {
        if (this.Attacks <= 0)
        {
            this._context.SetState(new SeekState(this._context));
            return;
        }

        Console.WriteLine($"Attacking...{this.Attacks--}");
    }
}

public class PatrolState : IState
{
    private readonly IStateContext context;
    public PatrolState(IStateContext context) => this.context = context;
    public void Tick()
    {
        Console.WriteLine("Patrolling...");
        this.TryChangeTransition();
    }

    private void TryChangeTransition()
    {
        if(Console.ReadLine() == "s")
            this.context.SetState(new SeekState(this.context) {DetectionRadius = 30.2f});
    }
}