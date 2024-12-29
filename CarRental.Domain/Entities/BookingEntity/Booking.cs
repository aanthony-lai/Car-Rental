using CarRental.Domain.Entities.Customers;
using CarRental.Domain.Entities.VechicleEntity;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities.Booking
{
    public class Booking : IEntity
    {
        public int Id { get; init; }
        public IVechicle Vechicle { get; private set; }
        public Customer Customer { get; private set; }
        public DateTime RentedOn { get; init; }
        public DateTime ReturnedOn { get; private set; }
        public decimal TotalCost { get; private set; }
        public BookingStatuses Status { get; private set; }

        public Booking(IVechicle vechicle, Customer customer)
        {
            if (vechicle is null)
                throw new ArgumentException("The selected vechicle is invalid.");

            if (customer is null)
                throw new ArgumentException($"The selected customer is invalid.");

            Id += 1;
            Vechicle = vechicle;
            Customer = customer;
            RentedOn = DateTime.Now;
            Status = BookingStatuses.Open;
        }
    }
}
