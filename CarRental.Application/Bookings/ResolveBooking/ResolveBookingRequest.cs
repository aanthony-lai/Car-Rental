using MediatR;

namespace CarRental.Application.Bookings.ResolveBooking;

public class ResolveBookingRequest: IRequest
{
    public int BookingId { get; }
    public ResolveBookingRequest(int bookingId)
    {
        BookingId = bookingId;
    }
}