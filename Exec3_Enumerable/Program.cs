using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var items=Enumerable.Range(1,10);

			foreach (var t in items)
			{
				Console.WriteLine(t);
			}

			var items2 = Enumerable.Range(10, 6);

			foreach (var i in items2)
			{
				Console.WriteLine(i);
			}
		}
	}
}
