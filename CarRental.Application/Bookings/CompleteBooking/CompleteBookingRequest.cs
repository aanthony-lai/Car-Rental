using MediatR;

namespace CarRental.Application.Bookings.CompleteBooking;

public class CompleteBookingRequest: IRequest
{
    public CompleteBookingModel ResolveBookingModel { get; }
    public CompleteBookingRequest(CompleteBookingModel resolveBookingModel)
    {
        ResolveBookingModel = resolveBookingModel;
    }
}