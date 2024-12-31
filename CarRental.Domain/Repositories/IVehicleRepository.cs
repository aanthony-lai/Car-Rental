using CarRental.Domain.Entities.VehicleEntity;

namespace CarRental.Domain.Repositories
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetAsync();
        Task<Vehicle?> GetByRegNumberAsync(string regNumber);
        Task SaveAsync(Vehicle type);
    }
}
