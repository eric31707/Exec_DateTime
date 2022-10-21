using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			Console.WriteLine("今天是" + now);
			int year = now.Year;
			int month = now.Month;
			DateTime result = new DateTime(year, month, 1);
			Console.WriteLine(result);
		}
	}
}
