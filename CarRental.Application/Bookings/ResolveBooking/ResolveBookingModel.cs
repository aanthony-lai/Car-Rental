namespace CarRental.Application.Bookings.ResolveBooking;

public class ResolveBookingModel
{
    public int BookingId { get; }
    public decimal Distance { get; }
    
    public ResolveBookingModel(int bookingId, decimal distance)
    {
        BookingId = bookingId;
        Distance = distance;
    }
}