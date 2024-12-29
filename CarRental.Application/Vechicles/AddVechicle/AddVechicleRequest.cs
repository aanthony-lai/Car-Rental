using MediatR;

namespace CarRental.Application.Vechicles
{
    public class AddVechicleRequest: IRequest<bool>
    {
        public AddVechicleModel AddVechicleModel { get; }
        public AddVechicleRequest(AddVechicleModel addVechicleModel) 
        {
            AddVechicleModel = addVechicleModel;
        }
    }
}
