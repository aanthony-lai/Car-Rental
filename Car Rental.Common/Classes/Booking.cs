using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
	public class Booking : IBooking
	{
		public int bookingID { get; set; }
		public string regNumber { get; set; }
		public ICustomer customer { get; set; }
		public int kmRented { get; set; }
		public int kmReturned { get; set; }
		public string rented { get; set; }
		public string returned { get; set; }
		public int cost { get; set; }
		public BookingStatuses status { get; set; }
		public Booking(string RegNumber, ICustomer Customer, int KmRented, string Rented)
		{
			bookingID += 1;
			regNumber = RegNumber;
			customer = Customer;
			kmRented = KmRented;
			rented = Rented;
			status = BookingStatuses.Open;
		}
	}
}
