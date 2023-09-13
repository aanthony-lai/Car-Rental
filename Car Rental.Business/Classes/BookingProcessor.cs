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

		public IEnumerable<IVechicle> GetVechicles(VechicleStatuses status = default)
		{
			return _db.getVechicles().Where(car => car.status == VechicleStatuses.Available);
		}


		public IEnumerable<IBooking> GetBookings()
		{
			return _db.getBookings();
		}

		public async Task createBookings(IVechicle vechicle)
		{
			 await _db.createBookings(vechicle); 
		}
	}
}
