namespace Airport_Class4;

public class LandingPad : LandingZone
{
    private Helicopter? _currentVehicle;

    public LandingPad(string id) : base(id)
    {
        
    }

    public override void Land(AirVehicle vehicle)
    {
        base.Land(vehicle);
        _currentVehicle = vehicle as Helicopter;
    }

    public override void TakeOff(AirVehicle vehicle)
    {
        base.TakeOff(vehicle);
        _currentVehicle = null;
    }
}