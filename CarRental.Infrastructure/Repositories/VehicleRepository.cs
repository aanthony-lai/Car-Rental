using CarRental.Domain.Repositories;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities.VechicleEntity;

namespace CarRental.Application.Repositories
{
    public sealed class VehicleRepository : IVehicleRepository
    {
        private readonly IDataStore _dataStore;
        public VehicleRepository(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<IEnumerable<IVehicle>> GetAsync()
        {
            return await _dataStore.GetDataAsync<IVehicle>();
        }

        public async Task<IVehicle?> GetByRegNumberAsync(string regNumber)
        {
            var vehicles = await _dataStore.GetDataAsync<IVehicle>();
            return vehicles.FirstOrDefault(vehicle => vehicle.RegNumber == regNumber) 
                   ?? null;
        }

        public async Task SaveAsync(IVehicle vehicle)
        {
            await _dataStore.SaveDataAsync(vehicle);
        }
    }
}
