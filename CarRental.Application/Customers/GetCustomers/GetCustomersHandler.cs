using CarRental.Domain.Entities.Customers;
using CarRental.Domain.Repositories;
using MediatR;

namespace CarRental.Application.Customers
{
    public sealed class GetCustomersHandler : IRequestHandler<GetCustomersRequest, List<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;
        public GetCustomersHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> Handle(GetCustomersRequest request, CancellationToken cancellationToken)
        {
            return (await _customerRepository.GetAsync()).ToList();
        }
    }
}
