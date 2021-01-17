using System;
using PartOne;

namespace Test_app
{
	class Program
	{
		static void Main(string[] args)
		{
			var x = Scrambler.Encode(new string[] { "123","321" },"321");
			foreach (var item in x)
			{
				Console.WriteLine(item);

			}
			var z= Scrambler.Decode(x, "321");
			foreach (var item in z)
			{
				Console.WriteLine(item);

			}
		}
	}
}
