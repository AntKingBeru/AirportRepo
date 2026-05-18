using static System.Console;

namespace Airport_Class4.AirportRepo;

public class Airplane : AirVehicle
{
    public Airplane(IMediator mediator) : base(mediator)
    {
        
    }

    public override void Land(string zone)
    {
        WriteLine($"The {GetType().Name} is landing in runway {zone}");
    }

    public override void TakeOff(string zone)
    {
        WriteLine($"The {GetType().Name} is taking off from runway {zone}");
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