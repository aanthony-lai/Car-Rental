using CarRental.Domain.Entities.Customers;
using MediatR;

namespace CarRental.Application.Customers
{
    public sealed class GetCustomersRequest: IRequest<List<Customer>>
    {

    }
}
