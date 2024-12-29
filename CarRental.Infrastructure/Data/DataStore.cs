using CarRental.Application.Interfaces;
using CarRental.Domain.Entities;

namespace CarRental.Application.Data
{
    public sealed class DataStore : IDataStore
    {
        private readonly Dictionary<Type, ICollection<IEntity>> _data = new Dictionary<Type, ICollection<IEntity>>();

        public DataStore()
        {
            SeedData();
        }

        public async Task<IEnumerable<IEntity>> GetDataAsync<IEntity>()
        {
            await Task.Delay(100);

            if (_data.TryGetValue(typeof(IEntity), out var dataCollection) &&
                dataCollection is IEnumerable<IEntity> selectedCollection)
            {
                return selectedCollection;
            }

            throw new InvalidOperationException("No data was found.");
        }

        public async Task SaveDataAsync<IEntity>(IEntity entity)
        {
            await Task.Delay(1000);

            if (_data.TryGetValue(typeof(IEntity), out var dataCollection) &&
                dataCollection is ICollection<IEntity> selectedCollection)
            {
                selectedCollection.Add(entity);
            }

            throw new InvalidOperationException("Data type is not supported.");
        }

        private void SeedData()
        {
            //_data[typeof(Booking)] = new List<IEntity>();

            //_data[typeof(Customer)] = new List<IEntity>()
            //{
            //    new Customer(12345, "Doe", "John"),
            //    new Customer(98765, "Doe", "Jane")
            //};

            //_data[typeof(IVechicle)] = new List<IEntity>()
            //{
            //    new Car("ABC123", "Volvo", 10000, 1, VechicleType.Combi, 200),
            //    new Car("DEF456", "Saab", 20000, 1, VechicleType.Sedan, 100),
            //    new Car("GHI789", "Tesla", 1000, 3, VechicleType.Sedan, 100),
            //    new Car("JKL012", "Jeep", 5000, 1.5, VechicleType.Van, 300),
            //    new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VechicleType.Motorcycle, 50)
            //};
        }
    }
}
