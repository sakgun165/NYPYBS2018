using System;

namespace Islem2IO
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 5;
			Console.WriteLine (i is int);
			Console.WriteLine (i is double);
			Console.WriteLine (i is object);
			Console.Write ("Bir sayı girin: ");
			int sayi = Convert.ToInt32 (Console.ReadLine ());
			string yaz=sayi<10?"10'dan küçük":"10'dan büyük veya eşit";
			Console.WriteLine (yaz);
		}
	}
}
