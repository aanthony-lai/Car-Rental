using Car_Rental.Common.Classes;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Data.Classes;

namespace Car_Rental.Business.Classes
{
	public class BookingProcessor
	{
		private readonly IData _db;

		public BookingProcessor()
		{
			_db = new dataCollection();
		}

		public IEnumerable<ICustomer> GetCustomers()
		{
			return _db.getCustomers();
		}

		public async Task CreateCustomer(int Ssn, string LastName, string FirstName)
		{
			await _db.CreateCustomer(Ssn, LastName, FirstName);
		}

		public IEnumerable<IVechicle> GetVechicles()
		{
			return _db.getVechicles();
		}

		public async Task CreateVechicle(IVechicle newVechicle)
		{
			await _db.CreateVechicle(newVechicle);
		}

		public IEnumerable<IBooking> GetBookings()
		{
			return _db.getBookings();
		}
		public async Task UpdateBooking(IVechicle vechicle, int distance)
		{
			DateTime returned = DateTime.Now;
			IBooking originalBooking = GetBookings().FirstOrDefault(booking => booking.regNumber == vechicle.regNumber);
			string returnedWithoutTime = returned.ToString("yyyy-MM-dd");
			DateTime.TryParse(returnedWithoutTime, out DateTime returnDate);
			//DateTime.TryParse(originalBooking.rented, out DateTime rented);
			TimeSpan difference = returnDate - returned;
			int numberOfDaysRented = (int)difference.TotalDays;
			double cost = (vechicle.costPerDay * numberOfDaysRented) + (distance * vechicle.costPerKm);
			int KmReturned = vechicle.odometer + distance;
			await _db.UpdateBooking(vechicle, returnedWithoutTime, cost, KmReturned, distance, originalBooking);
		}

		public async Task createBookings(IVechicle vechicle, ICustomer customer)
		{
			DateTime today = DateTime.Now;
			string todayWithoutTime = today.ToString("yyyy-MM-dd");
			Booking booking = new Booking(vechicle.regNumber, customer, vechicle.odometer, todayWithoutTime);
			await _db.createBookings(booking, customer);
		}
	}
}
