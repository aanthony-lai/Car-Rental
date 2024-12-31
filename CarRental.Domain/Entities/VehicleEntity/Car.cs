using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.VehicleEntity
{
    public class Car : Vehicle
    {
        public Car(
            string regNumber,
            string brand,
            VehicleType type,
            decimal odometer = 0,
            decimal costPerKm = 0) : base(regNumber, brand, type, odometer, costPerKm)
        {

        }
    }
}
