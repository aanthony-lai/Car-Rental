using CarRental.Domain.Repositories;
using CarRental.Domain.Entities.VehicleEntity;
using CarRental.Infrastructure.Data;

namespace CarRental.Application.Repositories
{
    public sealed class VehicleRepository : IVehicleRepository
    {
        private readonly IDataStore _dataStore;
        public VehicleRepository(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<IEnumerable<Vehicle>> GetAsync()
        {
            return await _dataStore.GetDataAsync<Vehicle>();
        }

        public async Task<Vehicle?> GetByRegNumberAsync(string regNumber)
        {
            var vehicles = await _dataStore.GetDataAsync<Vehicle>();
            return vehicles.FirstOrDefault(vehicle => vehicle.RegNumber == regNumber) 
                   ?? null;
        }

        public async Task SaveAsync(Vehicle vehicle)
        {
            await _dataStore.SaveDataAsync(vehicle);
        }
    }
}
