using System;

namespace RandomIO
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random rnd = new Random ();
			Console.WriteLine (rnd.Next(10,20));
			Console.WriteLine (rnd.Next(50));
			Console.WriteLine (rnd.NextDouble());
		}
	}
}
