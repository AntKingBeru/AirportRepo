namespace Airport_Class4;

public class Runway : LandingZone
{
    private Airplane? _currentVehicle;
    
    public Runway(string id) : base(id)
    {
        
    }
    
    public override void Land(AirVehicle vehicle)
    {
        base.Land(vehicle);
        _currentVehicle = vehicle as  Airplane;
    }

    public override void TakeOff(AirVehicle vehicle)
    {
        base.TakeOff(vehicle);
        _currentVehicle = null;
    }
}