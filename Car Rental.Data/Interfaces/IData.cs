using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Classes;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Interfaces
{
	public interface IData
	{
		IEnumerable<ICustomer> getCustomers();
		IEnumerable<IVechicle> getVechicles();
		IEnumerable<IBooking> getBookings();
		Task createBookings(Booking booking, ICustomer customer);
		Task CreateCustomer(int ssn, string lastName, string firstName);
		Task CreateVechicle(IVechicle newVechicle);
		Task UpdateBooking(IVechicle vechicle, string returned, double cost, int KmReturned, int distance, IBooking initialBooking);
		void seedData();
	}
}
