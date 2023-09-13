using Car_Rental.Common.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Interfaces
{
	public interface IBooking
	{
		Car regNumber { get; set; }
		Customer customer { get; set; }
		int kmRented { get; set; }
		int kmReturned { get; set; }
		DateTime rented { get; set; }
		DateTime returned { get; set; }
		int cost { get; set; }
	}
}
