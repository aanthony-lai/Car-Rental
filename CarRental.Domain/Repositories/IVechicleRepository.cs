using CarRental.Domain.Entities.VechicleEntity;

namespace CarRental.Domain.Repositories
{
    public interface IVechicleRepository
    {
        Task<IEnumerable<IVechicle>> GetAsync();
        Task SaveAsync(IVechicle type);
    }
}
