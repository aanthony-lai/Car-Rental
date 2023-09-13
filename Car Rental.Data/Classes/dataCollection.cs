using Car_Rental.Common.Classes;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Data.Classes
{
	public class dataCollection : IData
	{
		public readonly List<ICustomer> _customers = new List<ICustomer>();
		public readonly List<IVechicle> _vechicles = new List<IVechicle>();
		public readonly List<IBooking> _bookings = new List<IBooking>();
		
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
			_bookings.Add(new Booking("ABC987", "John", 10000, DateTime.Today));
			
		}

		public IEnumerable<ICustomer> getCustomers()
		{
			return _customers;
		}
		
		public IEnumerable<IVechicle> getVechicles(VechicleStatuses status = default)
		{
			return _vechicles;
		}
		
		public IEnumerable<IBooking> getBookings()
		{
			return _bookings;
		}

		public async Task createBookings(IVechicle vechicle)
		{
			await Task.Delay(1000);
			DateTime today = DateTime.Today;
			_bookings.Add(new Booking(vechicle.regNumber.ToString(), " ", Convert.ToInt32(vechicle.odometer), today));
		}
	}
}
