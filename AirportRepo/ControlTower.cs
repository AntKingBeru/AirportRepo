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
            WriteLine($"Flight {plane.FlightNumber}, cleared to land {_runway.Id}");
            plane.Land(_runway.Id);
            _runway.Land();
        }
        else
        {
            WriteLine($"Runway {_runway.Id} is busy. Stay in the air.");
        }
    }

    public void LandChopper(Helicopter chopper)
    {
        if (_pad.IsFree)
        {
            WriteLine($"Flight {chopper.FlightNumber}, cleared to land {_pad.Id}");
            chopper.Land(_pad.Id);
            _pad.Land();
        }
        else
        {
            WriteLine($"Pad {_pad.Id} is busy. Stay in the air.");
        }
    }
    
    
    public void TakeOffPlane(Airplane plane)
    {
        if (!_runway.IsFree)
        {
            WriteLine($"Flight {plane.FlightNumber}, take off from Pad {_runway.Id}.");
            plane.TakeOff(_runway.Id);
            _runway.TakeOff();
        }
        else
        {
            WriteLine($"There is no vehicle on the {_runway.Id}");
        }
    }

    public void TakeOffChopper(Helicopter chopper)
    {
        if (!_pad.IsFree)
        {
            WriteLine($"Flight {chopper.FlightNumber}, take off from Pad {_runway.Id}.");
            chopper.TakeOff(_pad.Id);
            _pad.TakeOff();
        }
        else
        {
            WriteLine($"There is no vehicle on the {_pad.Id}");
        }
    }
    

    public void Notify(AirVehicle sender, string action)
    {
        switch (action)
        {
            case "Land":
                WriteLine($" Tower, this is Flight {sender.FlightNumber}, requesting landing clearence");
                HandleLandSender(sender);
                break;
            case "TakeOff":
                WriteLine($"Tower, this is Flight {sender.FlightNumber} Type {sender.GetType().Name}  We need clear air to take off.");
                HandleTakeOffSender(sender);
                break;
        }
    }


    private void HandleLandSender(AirVehicle sender)
    {
        switch (sender)
        {
            case Airplane plane:
                LandPlane(plane);
                break;
            case Helicopter chopper:
                LandChopper(chopper);
                break;
            
            default:
                WriteLine("Unknown vehicle type.");
                break;
        }
    }
    
    
    private void HandleTakeOffSender(AirVehicle sender)
    {
        switch (sender)
        {
            case Airplane plane:
                TakeOffPlane(plane);
                break;
            case Helicopter chopper:
                TakeOffChopper(chopper);
                break;
            
            default:
                WriteLine("Unknown vehicle type.");
                break;
        }
    }
}