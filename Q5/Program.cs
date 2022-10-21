using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入年份");
			string input = Console.ReadLine();
			int year = Convert.ToInt32(input);
			DateTime first = new DateTime(year, 1, 1);
			DateTime finaldays = first;
			int dayofweekint = (int)first.DayOfWeek;
			//Console.WriteLine(dayOfWeek);
			if (dayofweekint > 0)
			{
				int numberdays = 7 - dayofweekint;
				finaldays = first.AddDays(numberdays);
			}
			while (finaldays.Year < year + 1)
			{
				Console.WriteLine(finaldays);
				finaldays = finaldays.AddDays(7);
			}
		}
	}
}
