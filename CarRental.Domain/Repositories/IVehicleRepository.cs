using CarRental.Domain.Entities.VechicleEntity;

namespace CarRental.Domain.Repositories
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<IVehicle>> GetAsync();
        Task<IVehicle?> GetByRegNumberAsync(string regNumber);
        Task SaveAsync(IVehicle type);
    }
}
