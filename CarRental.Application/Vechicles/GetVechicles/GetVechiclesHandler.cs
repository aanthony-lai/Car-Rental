using CarRental.Domain.Entities.VechicleEntity;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Vechicles.GetVechicles;

public sealed class GetVechiclesHandler: IRequestHandler<GetVechiclesRequest, List<IVehicle>>
{
    private readonly IVehicleRepository _vehicleRepository;

    public GetVechiclesHandler(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }
    
    public async Task<List<IVehicle>> Handle(GetVechiclesRequest request, CancellationToken cancellationToken)
    {
        return (await _vehicleRepository.GetAsync()).ToList();
    }
}