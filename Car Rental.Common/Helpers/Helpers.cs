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
		
		public int customerSSN { get; set; }
		public ICustomer? customer { get; set; }
		public string? regNO { get; set; }
		public string? brand { get; set; }
		public int odometer { get; set; }
		public double costPerKm { get; set; }
		public VechicleTypes type { get; set; }
		public int pricePerDay { get; set; }
		public int distance { get; set; }
	}


}
