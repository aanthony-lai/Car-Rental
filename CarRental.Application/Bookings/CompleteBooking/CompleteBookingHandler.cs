using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Bookings.CompleteBooking;

public class CompleteBookingHandler(
    IBookingRepository bookingRepository,
    IVehicleRepository vehicleRepository,
    IMediator mediator): IRequestHandler<CompleteBookingRequest>
{
    public async Task Handle(CompleteBookingRequest request, CancellationToken cancellationToken)
    {
        var booking = await bookingRepository.GetByIdAsync(request.ResolveBookingModel.BookingId);
        
        if (booking is null)
            throw new ArgumentException(
                $"Booking with id: {request.ResolveBookingModel.BookingId} was not found");

        var vehicle = await vehicleRepository.GetByRegNumberAsync(booking.RegNumber);
        
        if (vehicle is null)
            throw new ArgumentException($"Vehicle with reg number {booking.RegNumber} does not exist");
        
        booking.Complete(request.ResolveBookingModel.Distance);
        
        foreach (var domainEvent in booking.DomainEvents)
        {
            await mediator.Publish(domainEvent);
        }

        booking.ClearDomainEvents();
    }
}
        