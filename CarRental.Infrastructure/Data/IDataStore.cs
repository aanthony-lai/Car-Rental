using CarRental.Domain.Base;

namespace CarRental.Infrastructure.Data
{
    public interface IDataStore
    {
        Task<List<T>> GetDataAsync<T>() where T: Entity;
        Task SaveDataAsync<T>(T entity) where T: Entity;
    }
}
