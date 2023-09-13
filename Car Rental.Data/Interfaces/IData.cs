﻿using System;
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
		IEnumerable<ICustomer> getCustomers();
		IEnumerable<IVechicle> getVechicles(VechicleStatuses status = default);
		
		IEnumerable<IBooking> getBookings();
		Task createBookings(IVechicle vechicle);


		void seedData();
	}
}
