using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now=DateTime.Now;
			DateTime afterthreedays = DateTime.Now.AddDays(3);
			Console.WriteLine("今天是"+now);
			Console.WriteLine("應歸還時間是"+afterthreedays);
		}
	}
}
