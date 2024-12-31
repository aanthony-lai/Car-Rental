using MediatR;

namespace CarRental.Application.Customers
{
    public sealed class AddCustomerRequest: IRequest
    {
        public AddCustomerModel AddCustomerModel { get; set; } = null!;
        public AddCustomerRequest(AddCustomerModel addCustomerModel) 
        {
            AddCustomerModel = addCustomerModel;
        }
    }
}
