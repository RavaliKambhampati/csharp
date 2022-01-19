using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		public void calculation()
		{
			
			Console.WriteLine("enter a priciple");
			double p = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("enter time:");
			double t = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("enter rateof interest:");
			double r = Convert.ToDouble(Console.ReadLine());
			double simpleinterest = p * t * r / 100;
			Console.WriteLine("simpleinterest is:"+simpleinterest);
		}
		static void Main(string[] args)
		{
			Program objpr = new Program();
			objpr.calculation();
			Console.Read();

		}
	}
}
