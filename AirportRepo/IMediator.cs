namespace Airport_Class4.AirportRepo;

public interface IMediator
{
    void Notify (AirVehicle sender, string message);
}