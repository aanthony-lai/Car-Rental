using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Interfaces
{
	public interface ICustomer
	{
		bool isRenting { get; set; }
		int ssn { get; set; }
		string lastName { get; set; }
		string firstName { get; set; }
	}
}
