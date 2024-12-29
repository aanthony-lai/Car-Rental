using CarRental.Domain.Repositories;
using CarRental.Application.Interfaces;
using CarRental.Domain.Entities.VechicleEntity;

namespace CarRental.Application.Repositories
{
    public sealed class VechicleRepository : IVechicleRepository
    {
        private readonly IDataStore _dataStore;
        public VechicleRepository(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<IEnumerable<IVechicle>> GetAsync()
        {
            return await _dataStore.GetDataAsync<IVechicle>();
        }

        public async Task SaveAsync(IVechicle vechicle)
        {
            await _dataStore.SaveDataAsync(vechicle);
        }
    }
}
