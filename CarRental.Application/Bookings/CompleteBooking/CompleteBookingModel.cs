namespace CarRental.Application.Bookings.CompleteBooking;

public class CompleteBookingModel
{
    public int BookingId { get; }
    public decimal Distance { get; }
    
    public CompleteBookingModel(int bookingId, decimal distance)
    {
        BookingId = bookingId;
        Distance = distance;
    }
}