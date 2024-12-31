using CarRental.Domain.Base;

namespace CarRental.Domain.Entities.BookingEntity
{
    public sealed class BookingCompletedDomainEvent : DomainEvent
    {
        public string RegNumber { get; } = string.Empty;
        public decimal TotalDistance { get; }
        public BookingCompletedDomainEvent(string regNumber, decimal totalDistance) 
        {
            RegNumber = regNumber;
            TotalDistance = totalDistance;
        }
    }
}
