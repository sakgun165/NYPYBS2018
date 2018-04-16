using System;

namespace AkisKontrol1IO
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x, y;
			Console.Write ("Birinci sayıyı girin: ");
			x = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("İkinci sayıyı girin: ");
			y = Convert.ToInt32 (Console.ReadLine ());

			//if(int.TryParse(Console.ReadLine(),y))
			//	Console.WriteLine ("Dönüştürme başarılı!");

			if (x > y) {
				Console.WriteLine ("\n1. sayı büyük");
				Console.WriteLine ("\n1. sayı büyük");
			}
			else
				Console.WriteLine ("\n2. sayı büyük");
		}
	}
}
