namespace Airport_Class4.AirportRepo;

public abstract class AirVehicle
{
    protected IMediator Mediator;
    public string FlightNumber;

    protected AirVehicle(IMediator mediator, string flightNumber)
    {
        Mediator = mediator;
        FlightNumber = flightNumber;
    }
    public abstract void Land(string zone);
    public abstract void TakeOff(string zone);
    public abstract void Send(string message);
    public abstract void Receive(string message);
}