using MediatR;

namespace CarRental.Application.Bookings.ResolveBooking;

public class ResolveBookingRequest: IRequest
{
    public ResolveBookingModel ResolveBookingModel { get; }
    public ResolveBookingRequest(ResolveBookingModel resolveBookingModel)
    {
        ResolveBookingModel = resolveBookingModel;
    }
}