using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
	public class Customer : ICustomer
	{
		public bool isRenting { get; set; }
		public int ssn { get; set; }
		public string lastName { get; set; }
		public string firstName { get; set; }

		public Customer(int Ssn, string LastName, string FirstName)
		{
			isRenting = false;
			ssn = Ssn;
			lastName = LastName;
			firstName = FirstName;
		}
	}
}
