using CarRental.Domain.Entities.Vechicle;
using CarRental.Domain.Entities.VechicleEntity;
using CarRental.Domain.Enums;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Vechicles
{
    public sealed class AddVechicleHandler : IRequestHandler<AddVechicleRequest, bool>
    {
        private readonly IVehicleRepository _vehicleRepository;
        public AddVechicleHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<bool> Handle(AddVechicleRequest request, CancellationToken cancellationToken)
        {
            IVehicle vehicle = request.AddVechicleModel.Type == VehicleType.Motorcycle
                ? new Motorcycle(
                    request.AddVechicleModel.RegNumber,
                    request.AddVechicleModel.Brand,
                    request.AddVechicleModel.Odometer,
                    request.AddVechicleModel.CostPerKm)
                : new Car(
                    request.AddVechicleModel.RegNumber,
                    request.AddVechicleModel.Brand,
                    request.AddVechicleModel.Type,
                    request.AddVechicleModel.Odometer,
                    request.AddVechicleModel.CostPerKm);

            await _vehicleRepository.SaveAsync(vehicle);
            return true;
        }
    }
}
