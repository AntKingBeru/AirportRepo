namespace Airport_Class4;

public abstract class AirVehicle
{
    protected IMediator Mediator;

    protected AirVehicle()
    {
        
    }

    protected AirVehicle(IMediator mediator)
    {
        Mediator = mediator;
    }
    
    public abstract void Send(string message);
    public abstract void Receive(string message);
}