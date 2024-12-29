using MediatR;

namespace CarRental.Application.Customers
{
    public sealed class AddCustomerRequest: IRequest<bool>
    {
        public AddCustomerModel AddCustomerModel { get; set; } = null!;
        public AddCustomerRequest(AddCustomerModel addCustomerModel) 
        {
            AddCustomerModel = addCustomerModel;
        }
    }
}
