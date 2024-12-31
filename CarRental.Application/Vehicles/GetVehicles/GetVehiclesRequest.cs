using CarRental.Domain.Entities.VehicleEntity;
using MediatR;

namespace CarRental.Application.Vehicles.GetVehicles;

public sealed class GetVehiclesRequest: IRequest<List<Vehicle>>
{
    
}