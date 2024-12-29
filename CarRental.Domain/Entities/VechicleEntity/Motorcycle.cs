using CarRental.Domain.Entities.VechicleEntity;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.Vechicle
{
    public class Motorcycle : IVechicle
    {
        public string RegNumber { get; init; } = string.Empty;
        public string Brand { get; init; } = string.Empty;
        public decimal Odometer { get; init; }
        public decimal CostPerKm { get; private set; }
        public int CostPerDay { get; private set; }
        public VechicleType Type { get; init; }
        public VechicleStatus Status { get; private set; }

        public Motorcycle(
            string regNumber,
            string brand,
            decimal odometer = 0,
            decimal costPerKm = 0)
        {
            if (string.IsNullOrWhiteSpace(regNumber) ||
                regNumber.Length != 6)
            {
                throw new ArgumentException("Invalid registration number.");
            }

            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Brand name can't be empty.");

            RegNumber = regNumber;
            Brand = brand;
            Odometer = odometer;
            CostPerKm = costPerKm;
            CostPerDay = (int)VechicleType.Motorcycle;
            Type = VechicleType.Motorcycle;
            Status = VechicleStatus.Available;
        }
    }
}
