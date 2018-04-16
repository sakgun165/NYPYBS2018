using System;

namespace Rastgele
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random rnd = new Random ();//Nesne oluşturma
			Console.WriteLine (rnd.Next(10,20));
			Console.WriteLine (rnd.Next(50));
			//Console.WriteLine (rnd.Next);
			Console.WriteLine (rnd.NextDouble());

		}
	}
}
