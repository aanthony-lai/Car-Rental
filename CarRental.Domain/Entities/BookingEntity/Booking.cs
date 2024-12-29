using CarRental.Domain.Entities.Customers;
using CarRental.Domain.Entities.VechicleEntity;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.Booking
{
    public class Booking : IEntity
    {
        public string VechicleRegNumber { get; } = string.Empty;
        public IVehicle Vehicle { get; private set; }
        public int CustomerSSN { get; }
        public Customer Customer { get; private set; }
        public DateTime RentedOn { get; init; }
        public DateTime ReturnedOn { get; private set; }
        public decimal TotalCost { get; private set; }
        public BookingStatuses Status { get; private set; }

        public Booking(IVehicle vehicle, Customer customer)
        {
            VechicleRegNumber = vehicle.RegNumber;
            Vehicle = vehicle ?? throw new ArgumentException("The selected vechicle is invalid.");
            CustomerSSN = customer.SocialSecurityNumber;
            Customer = customer ?? throw new ArgumentException($"The selected customer is invalid.");
            RentedOn = DateTime.Now;
            Status = BookingStatuses.Open;
        }
    }
}
