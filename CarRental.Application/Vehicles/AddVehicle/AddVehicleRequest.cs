using MediatR;

namespace CarRental.Application.Vehicles
{
    public class AddVehicleRequest: IRequest<bool>
    {
        public AddVehicleModel AddVechicleModel { get; }
        public AddVehicleRequest(AddVehicleModel addVechicleModel) 
        {
            AddVechicleModel = addVechicleModel;
        }
    }
}
