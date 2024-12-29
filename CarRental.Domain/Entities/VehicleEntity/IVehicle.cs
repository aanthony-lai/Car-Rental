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
        VechicleType Type { get; }
        VechicleStatus Status { get; }
    }
}
