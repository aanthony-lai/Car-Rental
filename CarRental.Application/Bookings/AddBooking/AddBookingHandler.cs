using CarRental.Domain.Entities.Booking;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Bookings;

public class AddBookingHandler(
    IBookingRepository bookingRepository,
    IVehicleRepository vehicleRepository,
    ICustomerRepository customerRepository) : IRequestHandler<AddBookingRequest>
{
    public async Task Handle(AddBookingRequest request, CancellationToken cancellationToken)
    {
        var vechicle = await vehicleRepository.GetByRegNumberAsync(request.AddBookingModel.RegNumber);

        if (vechicle is null)
            throw new ArgumentException(
                $"Vehicle with reg number: {request.AddBookingModel.RegNumber} does not exist.");

        var customer = await customerRepository.GetBySsnAsync(request.AddBookingModel.SocialSecurityNumber);

        if (customer is null)
            throw new ArgumentException(
                $"Customer with ssn: {request.AddBookingModel.SocialSecurityNumber} does not exist.");

        await bookingRepository.SaveAsync(new Booking(vechicle, customer));
    }
}