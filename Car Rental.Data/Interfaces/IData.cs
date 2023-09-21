using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car_Rental.Common.Classes;
using Car_Rental.Common.Eunums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Interfaces
{
	public interface IData
	{
		IEnumerable<T> GetData<T>();
		Task PostData<T>(T value);
	}
}
