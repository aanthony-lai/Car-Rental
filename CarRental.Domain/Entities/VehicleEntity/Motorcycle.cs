using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.VehicleEntity
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(
            string regNumber,
            string brand,
            decimal odometer = 0,
            decimal costPerKm = 0): base(regNumber, brand, VehicleType.Motorcycle, odometer, costPerKm)
        {
           
        }
    }
}
