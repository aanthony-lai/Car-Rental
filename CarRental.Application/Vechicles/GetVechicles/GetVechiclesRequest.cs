using CarRental.Domain.Entities.VechicleEntity;
using MediatR;

namespace CarRental.Application.Vechicles.GetVechicles;

public sealed class GetVechiclesRequest: IRequest<List<IVehicle>>
{
    
}