using static System.Console;

namespace Airport_Class4.AirportRepo;

public class ControlTower : IMediator
{
    private readonly LandingPad _pad;
    private readonly Runway _runway;

    public ControlTower(LandingPad pad, Runway runway)
    {
        _pad = pad;
        _runway = runway;
    }

    public void LandPlane(Airplane plane)
    {
        if (_runway.IsFree)
        {
            plane.Land(_runway.Id);
        }
        else
        {
            WriteLine($"Runway {_runway.Id} is busy.");
        }
    }

    public void LandChopper(Helicopter chopper)
    {
        if (_pad.IsFree)
        {
            chopper.Land(_pad.Id);
        }
        else
        {
            WriteLine($"Pad {_pad.Id} is busy.");
        }
    }

    public void Notify(AirVehicle sender, string action)
    {
        switch (action)
        {
            case "Land":
                WriteLine($"{sender.GetType().Name} is landing.");
                break;
            case "TakeOff":
                WriteLine($"{sender.GetType().Name} is taking off.");
                break;
        }
    }
}