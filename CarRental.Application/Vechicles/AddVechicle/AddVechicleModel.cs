using CarRental.Domain.Enums;

namespace CarRental.Application.Vechicles
{
    public sealed class AddVechicleModel
    {
        public string RegNumber { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public decimal Odometer { get; set; }
        public decimal CostPerKm { get; set; }
        public VechicleType Type { get; set; }
        public VechicleStatus Status { get; set; }
    }
}
