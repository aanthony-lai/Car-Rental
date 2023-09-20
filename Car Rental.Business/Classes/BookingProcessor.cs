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
		public IEnumerable<T> GetData<T>()
		{
			return _db.GetData<T>();
		}
		public async Task CreateCustomer(int Ssn, string LastName, string FirstName)
		{
			ICustomer newCustomer = new Customer(Ssn, LastName, FirstName);
			await _db.PostData(newCustomer);
		}
		public async Task CreateVechicle(IVechicle newVechicle)
		{
			await _db.PostData(newVechicle);
		}
		public async Task createBookings(IVechicle vechicle, ICustomer customer)
		{
			DateTime today = DateTime.Now;
			string todayWithoutTime = today.ToString("yyyy-MM-dd");
			Booking booking = new Booking(vechicle.regNumber, customer, vechicle.odometer, todayWithoutTime);
			IVechicle? updateVechicleStatus = _db.GetData<IVechicle>().FirstOrDefault(vechicle => vechicle.regNumber == booking.regNumber);
			updateVechicleStatus.status = VechicleStatuses.Booked;
			customer.isRenting = true;
			await _db.PostData(booking);
		}
		public async Task UpdateBooking(IVechicle vechicle, int distance)
		{
			DateTime returned = DateTime.Now;
			IBooking originalBooking = GetData<IBooking>().FirstOrDefault(booking => booking.regNumber == vechicle.regNumber);
			string returnedWithoutTime = returned.ToString("yyyy-MM-dd");
			DateTime.TryParse(returnedWithoutTime, out DateTime returnDate);
			TimeSpan difference = returnDate - returned;
			int numberOfDaysRented = (int)difference.TotalDays;
			double cost = (vechicle.costPerDay * numberOfDaysRented) + (distance * vechicle.costPerKm);
			int KmReturned = vechicle.odometer + distance;
			await _db.UpdateBooking(vechicle, returnedWithoutTime, cost, KmReturned, distance, originalBooking);
		}
	}
}
