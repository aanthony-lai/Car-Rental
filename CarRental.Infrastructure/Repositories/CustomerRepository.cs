using CarRental.Domain.Entities.Customers;
using CarRental.Domain.Repositories;
using CarRental.Infrastructure.Data;

namespace CarRental.Application.Repositories
{
    public sealed class CustomerRepository : ICustomerRepository
    {
        private readonly IDataStore _dataStore;
        public CustomerRepository(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<IEnumerable<Customer>> GetAsync()
        {
            return await _dataStore.GetDataAsync<Customer>();
        }

        public async Task<Customer?> GetBySsnAsync(int ssn)
        {
            var customers = await _dataStore.GetDataAsync<Customer>();

            return customers.FirstOrDefault(c => c.SocialSecurityNumber == ssn) 
                ?? null;
        }

        public async Task SaveAsync(Customer customer)
        {
            await _dataStore.SaveDataAsync(customer);
        }
    }
}
