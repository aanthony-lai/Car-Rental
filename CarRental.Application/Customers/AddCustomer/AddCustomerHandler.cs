using CarRental.Domain.Entities.Customers;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Customers
{
    public sealed class AddCustomerHandler : IRequestHandler<AddCustomerRequest>
    {
        private readonly ICustomerRepository _customerRepository;
        public AddCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task Handle(AddCustomerRequest request, CancellationToken cancellationToken)
        {
            var existingCustomer = await _customerRepository
                .GetBySsnAsync(request.AddCustomerModel.SocialSecurityNumber);

            if (existingCustomer != null)
                throw new ArgumentException($"A customer with SSN: {existingCustomer.SocialSecurityNumber}, already exists.");

            var customer = new Customer(
                request.AddCustomerModel.FirstName,
                request.AddCustomerModel.LastName,
                request.AddCustomerModel.SocialSecurityNumber);

            await _customerRepository.SaveAsync(customer);
        }
    }
}
