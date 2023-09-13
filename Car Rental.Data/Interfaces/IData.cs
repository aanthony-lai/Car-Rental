using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Interfaces
{
	public interface IData
	{
		List<ICustomer> _customers { get; set; }
		List<IVechicle> _vechicles { get; set; }
		List<IBooking> _bookings { get; set; }

		IEnumerable<ICustomer> getCustomers();
		IEnumerable<IVechicle> getVechicles(VechicleStatuses status = default);
		IEnumerable<IBooking> getBookings();
	}
}
