namespace Airport_Class4;

public class ControlTower : IMediator
{
    private readonly List<LandingZone> _landings = new List<LandingZone>();

    public ControlTower(List<LandingZone> landings)
    {
        _landings = landings;
        foreach (var zone in _landings)
            zone.SetMediator(this);
    }

    public void AddLanding(LandingZone newZone)
    {
        _landings.Add(newZone);
        newZone.SetMediator(this);
    }

    public void RemoveLanding(LandingZone zone)
    {
        _landings.Remove(zone);
    }

    public void Notify(AirVehicle sender, string message)
    {
        if (message == "TakeOff")
        {
            Console.WriteLine("Control Tower: " + sender.GetType().Name + " is taking off.");
        }

        if (message == "Land")
        {
            Console.WriteLine("Control Tower: " + sender.GetType().Name + " is landing.");
        }
    }
}