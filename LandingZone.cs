using static System.Console;

namespace Airport_Class4.AirportRepo;

public abstract class LandingZone
{
    protected IMediator? Mediator;
    public string Id { get; }

    public bool IsFree { get; private set; }

    protected LandingZone(string id)
    {
        Id = id;
        IsFree = false;
    }

    public void SetMediator(IMediator mediator)
    {
        Mediator = mediator;
    }

    public void Land()
    {
        IsFree = true;
        WriteLine($"{Id} is now taken.");
    }
    
    public void TakeOff()
    {
        IsFree = false;
        WriteLine($"{Id} is now free.");
    }
}