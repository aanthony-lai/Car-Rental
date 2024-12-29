using CarRental.Domain.Entities.Booking;

namespace CarRental.Domain.Repositories
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAsync();
        Task SaveAsync(Booking type);
    }
}
