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
		readonly List<ICustomer> _customers = new List<ICustomer>();
		readonly List<IVechicle> _vechicles = new List<IVechicle>();
		readonly List<IBooking> _bookings = new List<IBooking>();
		
		public dataCollection()
		{
			seedData();
		}
		public void seedData()
		{
			_customers.Add(new Customer(12345, "Doe", "John"));
			_customers.Add(new Customer(98765, "Doe", "Jane"));
			_vechicles.Add(new Car("ABC123", "Volvo", 10000, 1, VechicleTypes.Combi, 200));
			_vechicles.Add(new Car("DEF456", "Saab", 20000, 1, VechicleTypes.Sedan, 100));
			_vechicles.Add(new Car("GHI789", "Tesla", 1000, 3, VechicleTypes.Sedan, 100));
			_vechicles.Add(new Car("JKL012", "Jeep", 5000, 1.5, VechicleTypes.Van, 300));
			_vechicles.Add(new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VechicleTypes.Motorcycle, 50));
		}
		public IEnumerable<T> GetData<T>()
		{
			if (typeof(T) == typeof(ICustomer))
			{
				return _customers.Cast<T>();
			}
			else if (typeof(T) == typeof(IVechicle))
			{
				return _vechicles.Cast<T>();
			}
			else if (typeof(T) == typeof(IBooking)) 
			{
				return _bookings.Cast<T>();
			}
			else
			{
				throw new InvalidOperationException("The data type is not supported");
			}
		}
		public async Task PostData<T>(T value)
		{
			await Task.Delay(100);

			if (typeof(T) == typeof(ICustomer))
			{
				ICustomer newCustomer = (ICustomer)(object)value;
				_customers.Add(newCustomer);
			}
			else if (typeof(T) == typeof(IVechicle))
			{
				IVechicle newVechicle = (IVechicle)(object)value;
				_vechicles.Add(newVechicle);
			}
			else if (typeof(T) == typeof(Booking)) 
			{
				IBooking newBooking = (IBooking)(Object)value;
				_bookings.Add(newBooking);
			}
			else
			{
				throw new InvalidCastException("Tha data type is not supported");
			}
		}
		public async Task UpdateBooking(IVechicle vechicle, string returned, double cost, int KmReturned, int distance, IBooking initialBooking)
		{
			await Task.Delay(100);
			IBooking? updateBooking = _bookings.FirstOrDefault(booking => booking.regNumber == vechicle.regNumber && booking.status == BookingStatuses.Open);
			ICustomer? customer = _customers.FirstOrDefault(customer => customer.ssn == initialBooking.customer.ssn);
			updateBooking.kmReturned = KmReturned;
			updateBooking.returned = returned;
			updateBooking.cost = (int)cost;
			updateBooking.status = BookingStatuses.Closed;
			vechicle.odometer = vechicle.odometer + distance;
			vechicle.status = VechicleStatuses.Available;
			customer.isRenting = false;
		}
		
	}
}
