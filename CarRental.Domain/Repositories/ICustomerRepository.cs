using CarRental.Domain.Entities.Customers;

namespace CarRental.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAsync();
        Task<Customer?> GetBySsnAsync(int ssn);
        Task SaveAsync(Customer type);
    }
}
