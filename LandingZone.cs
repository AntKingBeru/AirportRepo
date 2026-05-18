namespace Airport_Class4;

public abstract class LandingZone
{
    protected string Id;
    protected IMediator? Mediator;
    protected bool IsTaken;

    protected LandingZone(string id)
    {
        Id = id;
        IsTaken = false;
    }

    public void SetMediator(IMediator mediator)
    {
        Mediator = mediator;
    }

    public virtual void Land(AirVehicle vehicle)
    {
        // vehicle.Land();
        IsTaken = true;
    }
    
    public virtual void TakeOff(AirVehicle vehicle)
    {
        // vehicle.TakeOff();
        IsTaken = false;
    }
}