using static System.Console;

namespace Airport_Class4.AirportRepo;

public class Helicopter : AirVehicle
{
    public Helicopter(IMediator mediator, string flightNumber) : base(mediator, flightNumber)
    {
        
    }
    
    public override void Land(string zone)
    {
        WriteLine($"The {GetType().Name} is landing in pad {zone}");
    }

    public override void TakeOff(string zone)
    {
        WriteLine($"The {GetType().Name} is taking off from pad {zone}");
    }
    
    public override void Send(string message)
    {
        throw new NotImplementedException();
    }

    public override void Receive(string message)
    {
        throw new NotImplementedException();
    }
}