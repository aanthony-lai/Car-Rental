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
		public List<ICustomer> _customers = new List<ICustomer>();
		public List<IVechicle> _vechicles = new List<IVechicle>();
		public List<IBooking> _bookings = new List<IBooking>();
		
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
		public async Task createBookings(Booking booking)
		{
			await Task.Delay(2000);
			_bookings.Add(booking);
			string regNumber = booking.regNumber;
			IVechicle? statusToUpdate = _vechicles.FirstOrDefault(vechicle => vechicle.regNumber == regNumber);
			statusToUpdate.status = VechicleStatuses.Booked;
		}

		public IEnumerable<IBooking> getBookings()
		{
			return _bookings;
		}

		public async Task UpdateBooking(IVechicle vechicle, string returned, double cost, int KmReturned, int distance)
		{
			await Task.Delay(100);
			IBooking updatedBooking = _bookings.FirstOrDefault(booking => booking.regNumber == vechicle.regNumber && booking.status == BookingStatuses.Open);
			updatedBooking.kmReturned = KmReturned;
			updatedBooking.returned = returned;
			updatedBooking.cost = (int)cost;
			vechicle.odometer = vechicle.odometer + distance;
			vechicle.status = VechicleStatuses.Available;
			updatedBooking.status = BookingStatuses.Closed;
		}

		public IEnumerable<ICustomer> getCustomers()
		{
			return _customers;
		}

		public async Task CreateCustomer(int ssn, string lastName, string firstName)
		{
			await Task.Delay(100);
			_customers.Add(new Customer(ssn, lastName, firstName));
		}

		public IEnumerable<IVechicle> getVechicles(/*VechicleStatuses status = default*/)
		{
			return _vechicles;
		}
		public async Task CreateVechicle(IVechicle newVechicle)
		{
			await Task.Delay(100);
			_vechicles.Add(newVechicle);
		}
	}
}
