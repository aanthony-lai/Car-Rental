using Car_Rental.Common.Classes;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Data.Classes
{
	public class dataCollection : IData
	{
		private readonly Dictionary<Type, object> _data = new Dictionary<Type, object>();

		public dataCollection()
		{
			seedData();
		}
		void seedData()
		{
			_data[typeof(IBooking)] = new List<IBooking>();
			_data[typeof(ICustomer)] = new List<ICustomer>()
			{
				new Customer(12345, "Doe", "John"),
				new Customer(98765, "Doe", "Jane")
			};
			_data[typeof(IVechicle)] = new List<IVechicle>()
			{
				new Car("ABC123", "Volvo", 10000, 1, VechicleTypes.Combi, 200),
				new Car("DEF456", "Saab", 20000, 1, VechicleTypes.Sedan, 100),
				new Car("GHI789", "Tesla", 1000, 3, VechicleTypes.Sedan, 100),
				new Car("JKL012", "Jeep", 5000, 1.5, VechicleTypes.Van, 300),
				new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VechicleTypes.Motorcycle, 50)
			};
		}

		public IEnumerable<T> GetData<T>()
		{
			if (_data.TryGetValue(typeof(T), out var dataList) && dataList is List<T> typeOfList)
			{
				return typeOfList.ToList();
			}
			else
			{
				throw new InvalidOperationException("Data type cannot be found!");
			}
		}
		public async Task PostData<T>(T value)
		{
			await Task.Delay(1000);

			if (_data.TryGetValue(typeof(T), out var dataList) && dataList is List<T> typeOfList)
			{
				typeOfList.Add(value);
			}
			else
			{
				throw new InvalidOperationException("Data type is not supported!");
			}
		}
	}
}
