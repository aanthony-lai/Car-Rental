using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Classes;
using Car_Rental.Common.Eunums;

namespace Car_Rental.Common.Interfaces
{
	public interface IVechicle
	{
		string regNumber { get; set; }
		string brand { get; set; }
		int odometer { get; set; }
		double costPerKm { get; set; }
		VechicleTypes vechicleType { get; set; }
		int costPerDay { get; set; }
		VechicleStatuses status { get; set; }
	}
}
