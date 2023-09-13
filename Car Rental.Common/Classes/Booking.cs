using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
	public class Booking : IBooking
	{
		public string regNumber { get; set; }
		public string customer { get; set; }
		public int kmRented { get; set; }
		public int kmReturned { get; set; }
		public DateTime rented { get; set; }
		public DateTime returned { get; set; }
		public int cost { get; set; }
		public Booking(string RegNumber, string Customer, int KmRented, DateTime Rented)
		{
			regNumber = RegNumber;
			customer = Customer;
			kmRented = KmRented;
			rented = Rented;
		}
	}
}
