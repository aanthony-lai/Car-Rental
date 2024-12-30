using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.VechicleEntity
{
    public interface IVehicle : IEntity
    {
        string RegNumber { get; init; }
        string Brand { get; }
        decimal Odometer { get; }
        decimal CostPerKm { get; }
        int CostPerDay { get; }
        VehicleType Type { get; }
        VehicleStatus Status { get; }
        void MakeAvailable();
        void UpdateOdometer(decimal distance);
    }
}
