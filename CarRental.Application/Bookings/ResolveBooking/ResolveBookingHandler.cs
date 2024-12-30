using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Bookings.ResolveBooking;

public class ResolveBookingHandler(
    IBookingRepository bookingRepository,
    IVehicleRepository vehicleRepository): IRequestHandler<ResolveBookingRequest>
{
    public async Task Handle(ResolveBookingRequest request, CancellationToken cancellationToken)
    {
        var booking = await bookingRepository.GetByIdAsync(request.ResolveBookingModel.BookingId);
        
        if (booking is null)
            throw new ArgumentException(
                $"Booking with id: {request.ResolveBookingModel.BookingId} was not found");

        var vehicle = await vehicleRepository.GetByRegNumberAsync(booking.RegNumber);
        
        if (vehicle is null)
            throw new ArgumentException($"Vehicle with reg number {booking.RegNumber} does not exist");
        
        booking.Resolve(request.ResolveBookingModel.Distance);
        
        vehicle.UpdateOdometer(request.ResolveBookingModel.Distance);
        vehicle.MakeAvailable();
    }
}