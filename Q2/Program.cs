using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			DateTime afteronemonth = DateTime.Now.AddMonths(1);
			Console.WriteLine("今天是" + now);
			Console.WriteLine("應歸還時間是" + afteronemonth);
		}
	}
}
