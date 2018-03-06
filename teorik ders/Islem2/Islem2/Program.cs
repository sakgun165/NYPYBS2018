using System;

namespace Islem2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 10;
			Console.WriteLine (i is int);
			Console.WriteLine (i is double);
			Console.WriteLine (i is object);
			int sayi;
			sayi = Convert.ToInt32 (Console.ReadLine ());
			string yaz=sayi<25?"25'den küçük":"25'den büyük veya eşit";
			Console.WriteLine (yaz);
			Console.ReadKey ();
		}
	}
}
