using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			Console.WriteLine("今天是" + today);
			int year = today.Year;
			int month = today.Month;
			DateTime result = new DateTime(year, month, 1);
			//Console.WriteLine(result);
			DateTime lastmonth = result.AddDays(-1);
			DateTime nextmonth = lastmonth.AddMonths(1);
			Console.WriteLine($"本月底是,{nextmonth}");
		}
	}
}
