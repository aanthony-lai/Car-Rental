using CarRental.Domain.Entities.VehicleEntity;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Vehicles.GetVehicles;

public sealed class GetVehilesHandler: IRequestHandler<GetVehiclesRequest, List<Vehicle>>
{
    private readonly IVehicleRepository _vehicleRepository;

    public GetVehilesHandler(IVehicleRepository vehicleRepository)
    {
        _vehicleRepository = vehicleRepository;
    }
    
    public async Task<List<Vehicle>> Handle(GetVehiclesRequest request, CancellationToken cancellationToken)
    {
        return (await _vehicleRepository.GetAsync()).ToList();
    }
}