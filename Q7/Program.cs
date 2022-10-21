using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			Console.WriteLine("今天是" + now);
			int hours = now.Hour;
			if (hours >= 0 && hours <= 10)
			{
				Console.WriteLine("早安");
				return;
			}
			else if (hours >= 11 && hours <= 16)
			{
				Console.WriteLine("午安");
			}
			else    // if (hours >= 17 && hours <= 23)
			{
				Console.WriteLine("晚安");
			}

		}
	}
}
