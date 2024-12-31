using CarRental.Domain.Entities.Booking;
using CarRental.Domain.Repositories;
using CarRental.Infrastructure.Data;

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

        public async Task<Booking?> GetByIdAsync(int id)
        {
            var bookings = await _dataStore.GetDataAsync<Booking>();
            return bookings.SingleOrDefault(booking => booking.Id == id) ?? null;
        }

        public async Task SaveAsync(Booking booking)
        {
            await _dataStore.SaveDataAsync(booking);
        }
    }
}
