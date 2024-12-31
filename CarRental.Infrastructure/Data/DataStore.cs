using CarRental.Domain.Base;
using CarRental.Domain.Entities.Booking;
using CarRental.Domain.Entities.Customers;
using CarRental.Domain.Entities.VehicleEntity;
using CarRental.Domain.Enums;
using CarRental.Infrastructure.Data;

namespace CarRental.Application.Data
{
    public sealed class DataStore : IDataStore
    {
        private readonly Dictionary<Type, object> _data = new Dictionary<Type, object>();

        public DataStore()
        {
            SeedData();
        }

        public async Task<List<T>> GetDataAsync<T>() where T : Entity
        {
            await Task.Delay(100);

            if (_data.TryGetValue(typeof(T), out var dataCollection) 
                && dataCollection is List<T> selectedCollection)
            {
                return selectedCollection;
            }
            
            throw new InvalidOperationException("No data was found.");
        }

        public async Task SaveDataAsync<T>(T entity) where T : Entity
        {
            await Task.Delay(1000);

            if (_data.TryGetValue(typeof(T), out var dataCollection) 
                && dataCollection is List<T> selectedCollection)
            {
                selectedCollection.Add(entity);
            }
            else
            {
                throw new InvalidOperationException("Data type is not supported.");
            }
        }

        private void SeedData()
        {
            _data[typeof(Booking)] = new List<Booking>();

            _data[typeof(Customer)] = new List<Customer>()
            {
                new Customer("John", "Doe", 123456),
                new Customer("Jane", "Doe", 567891)
            };

            _data[typeof(Vehicle)] = new List<Vehicle>()
            {
                new Car("ABC123", "Volvo", VehicleType.Combi, 1000, 30),
                new Car("DEF456", "Saab", VehicleType.Sedan, 4500, 25),
                new Car("GHI789", "Tesla", VehicleType.Sedan, 500, 45),
                new Car("JKL012", "Ford", VehicleType.Truck, 7500, 40),
                new Car("MNO234", "Chevrolet", VehicleType.SUV, 3200, 28),
                new Motorcycle("PQR567", "Yamaha", 12000, 15),
                new Motorcycle("STU890", "Honda", 9000, 18)
            };
        }
    }
}
