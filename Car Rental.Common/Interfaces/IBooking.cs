using Car_Rental.Common.Classes;
using Car_Rental.Common.Eunums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Interfaces
{
	public interface IBooking
	{
		int bookingID { get; set; }
		string regNumber { get; set; }
		string customer { get; set; }
		int kmRented { get; set; }
		int kmReturned { get; set; }
		string rented { get; set; }
		string returned { get; set; }
		int cost { get; set; }
		BookingStatuses status { get; set; }
	}
}
