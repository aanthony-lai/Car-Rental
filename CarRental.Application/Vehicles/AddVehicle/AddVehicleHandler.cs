using CarRental.Domain.Entities.VehicleEntity;
using CarRental.Domain.Enums;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Vehicles
{
    public sealed class AddVehicleHandler : IRequestHandler<AddVehicleRequest, bool>
    {
        private readonly IVehicleRepository _vehicleRepository;
        public AddVehicleHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<bool> Handle(AddVehicleRequest request, CancellationToken cancellationToken)
        {
            var existingVehicle = await _vehicleRepository
                .GetByRegNumberAsync(request.AddVechicleModel.RegNumber);

            if (existingVehicle != null)
                throw new ArgumentException($"Reg number: {existingVehicle.RegNumber} is already in use.");

            Vehicle vehicle = request.AddVechicleModel.Type == VehicleType.Motorcycle
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
