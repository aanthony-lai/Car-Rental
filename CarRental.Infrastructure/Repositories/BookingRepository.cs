using CarRental.Domain.Entities.Booking;
using CarRental.Domain.Repositories;
using CarRental.Application.Interfaces;

namespace CarRental.Application.Repositories
{
    public sealed class BookingRepository : IBookingRepository
    {
        private readonly IDataStore _dataStore;
        public BookingRepository(IDataStore dataStore)
        {
            _dataStore = dataStore;
        } 

        public async Task<IEnumerable<Booking>> GetAsync()
        {
            return await _dataStore.GetDataAsync<Booking>();
        }

        public async Task SaveAsync(Booking booking)
        {
            await _dataStore.SaveDataAsync(booking);
        }
    }
}
