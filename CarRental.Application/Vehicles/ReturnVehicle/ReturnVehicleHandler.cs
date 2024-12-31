using CarRental.Domain.Entities.BookingEntity;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Vehicles.ReturnVehicle
{
    public class ReturnVehicleHandler(IVehicleRepository vehicleRepository) : INotificationHandler<BookingCompletedDomainEvent>
    {
        public async Task Handle(BookingCompletedDomainEvent notification, CancellationToken cancellationToken)
        {
            var vehicle = await vehicleRepository.GetByRegNumberAsync(notification.RegNumber);

            if (vehicle is null)
                throw new ArgumentException($"Vehicle with reg number: {notification.RegNumber} was not found.");

            vehicle.UpdateOdometer(notification.TotalDistance);
            vehicle.MakeAvailable();
        }
    }
}
