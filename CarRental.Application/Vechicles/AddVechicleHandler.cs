using CarRental.Domain.Entities.Vechicle;
using CarRental.Domain.Entities.VechicleEntity;
using CarRental.Domain.Enums;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Vechicles
{
    public sealed class AddVechicleHandler : IRequestHandler<AddVechicleRequest, bool>
    {
        private readonly IVechicleRepository _vechicleRepository;
        public AddVechicleHandler(IVechicleRepository vechicleRepository)
        {
            _vechicleRepository = vechicleRepository;
        }

        public async Task<bool> Handle(AddVechicleRequest request, CancellationToken cancellationToken)
        {
            IVechicle vechicle = request.AddVechicleModel.Type == VechicleType.Motorcycle
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

            await _vechicleRepository.SaveAsync(vechicle);
            return true;
        }
    }
}
