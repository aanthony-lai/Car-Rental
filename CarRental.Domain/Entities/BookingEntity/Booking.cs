using CarRental.Domain.Base;
using CarRental.Domain.Entities.BookingEntity;
using CarRental.Domain.Entities.Customers;
using CarRental.Domain.Entities.VehicleEntity;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.Booking
{
    public class Booking: Entity
    {
        public int Id { get; }
        public string RegNumber { get; } = string.Empty;
        public VehicleEntity.Vehicle Vehicle { get; }
        public int SocialSecurityNumber { get; }
        public Customer Customer { get; private set; }
        public DateTime RentedOn { get; }
        public DateTime ReturnedOn { get; private set; }
        public decimal TotalCost { get; private set; }
        public BookingStatuses Status { get; private set; }

        public Booking(VehicleEntity.Vehicle vehicle, Customer customer)
        {
            Id += 1;
            RegNumber = vehicle.RegNumber;
            Vehicle = vehicle ?? throw new ArgumentException("The selected vechicle is invalid.");
            SocialSecurityNumber = customer.SocialSecurityNumber;
            Customer = customer ?? throw new ArgumentException($"The selected customer is invalid.");
            RentedOn = DateTime.Now;
            Status = BookingStatuses.Open;
        }

        public void Complete(decimal totalDistance)
        {
            if (totalDistance < 0)
                throw new ArgumentException("The total distance cannot be negative.");
            
            ReturnedOn = DateTime.Now;
            TotalCost = Vehicle.CostPerDay * (ReturnedOn.Day - RentedOn.Day + 1) + totalDistance * Vehicle.CostPerKm;
            Status = BookingStatuses.Closed;

            base.AddDomainEvent(new BookingCompletedDomainEvent(this.RegNumber, totalDistance));
        }
    }
}
