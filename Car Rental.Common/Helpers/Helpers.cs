using Car_Rental.Common.Classes;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Car_Rental.Common.Helpers
{
	public class Helpers
	{
		public IVechicle CheckVechicleType(string regNumber, string brand, int odometer, double costPerKm, VechicleTypes type, int pricePerDay)
		{
			IVechicle newVechicle;
			if (type == VechicleTypes.Motorcycle)
			{
				newVechicle = new Motorcycle(regNumber.ToUpper(), brand, odometer, costPerKm, type, pricePerDay);
			}
			else
			{
				newVechicle = new Car(regNumber.ToUpper(), brand, odometer, costPerKm, type, pricePerDay);
			}
			return newVechicle;
		}
	}
}
