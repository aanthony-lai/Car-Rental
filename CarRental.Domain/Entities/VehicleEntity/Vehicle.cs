using CarRental.Domain.Base;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.VehicleEntity
{
    public abstract class Vehicle: Entity
    {
        public string RegNumber { get; init; } = string.Empty;
        public string Brand { get; init; } = string.Empty;
        public decimal Odometer { get; private set; }
        public decimal CostPerKm { get; }
        public int CostPerDay { get; }
        public VehicleType Type { get; }
        public VehicleStatus Status { get; private set; }

        protected Vehicle(
            string regNumber,
            string brand,
            VehicleType type,
            decimal odometer,
            decimal costPerKm) 
        {
            if (string.IsNullOrWhiteSpace(regNumber) || regNumber.Length != 6)
                throw new ArgumentException("Invalid registration number.");

            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Brand name can't be empty.");

            if (odometer < 0)
                throw new ArgumentException("Can't set odometer to a negative value.");

            if (costPerKm < 0)
                throw new ArgumentException("Can't set the cost per KM to a negative value.");

            RegNumber = regNumber;
            Brand = brand;
            Odometer = odometer;
            CostPerKm = costPerKm;
            CostPerDay = (int)type;
            Type = type;
            Status = VehicleStatus.Available;
        }

        public virtual void MakeAvailable()
        {
            Status = VehicleStatus.Available;
        }

        public virtual void UpdateOdometer(decimal distance)
        {
            if (distance < 0)
                throw new ArgumentException("Distance can't be negative.");

            Odometer += distance;
        }
    }
}
