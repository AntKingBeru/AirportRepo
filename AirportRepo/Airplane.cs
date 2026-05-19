using static System.Console;

namespace Airport_Class4.AirportRepo;

public class Airplane : AirVehicle
{
    public Airplane(IMediator mediator, string flightNumber) : base(mediator, flightNumber)
    {
        
    }

    public override void Land(string zone)
    {
        WriteLine($"The {GetType().Name} - {FlightNumber} is landing in runway {zone}");
    }

    public override void TakeOff(string zone)
    {
        WriteLine($"The {GetType().Name} - {FlightNumber} is taking off from runway {zone}");
    }

    public override void Send(string message)
    {
       Mediator.Notify(this, message);
    }

    public override void Receive(string message)
    {
        
    }
}