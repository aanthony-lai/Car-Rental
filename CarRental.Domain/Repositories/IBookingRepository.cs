using CarRental.Domain.Entities.Booking;

namespace CarRental.Domain.Repositories
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAsync();
        Task<Booking?> GetByIdAsync(int id);
        Task SaveAsync(Booking type);
    }
}
