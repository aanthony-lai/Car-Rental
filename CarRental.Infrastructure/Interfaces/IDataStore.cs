namespace CarRental.Application.Interfaces
{
    public interface IDataStore
    {
        Task<IEnumerable<IEntity>> GetDataAsync<IEntity>();
        Task SaveDataAsync<IEntity>(IEntity entity);
    }
}
