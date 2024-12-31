using CarRental.Domain.Enums;

namespace CarRental.Application.Vehicles
{
    public sealed class AddVehicleModel
    {
        public string RegNumber { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public decimal Odometer { get; set; }
        public decimal CostPerKm { get; set; }
        public VehicleType Type { get; set; }
        public VehicleStatus Status { get; set; }
    }
}
