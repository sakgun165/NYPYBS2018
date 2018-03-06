using System;

namespace AkisKontrol1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x, y;
			Console.WriteLine ("1. sayıyı girin: ");
			x = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("2. sayıyı girin: ");
			y = Convert.ToInt32 (Console.ReadLine ());

			if (x > y) {
				Console.WriteLine ("\n1. sayı büyük!");
				Console.WriteLine ("\n1. sayı büyük!");
			}
			else
				Console.WriteLine ("\n2. sayı büyük!");
		}
	}
}
