using System;

namespace H4OtoKiralama
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("km miktarını girin: ");
			int km = Convert.ToInt32 (Console.ReadLine ());
			double tutar;
			if (km < 100)
				tutar = 10 + km * 0.9;
			else
				tutar = 10 + 100 * 0.9 + (km - 100) * 0.6;
			Console.WriteLine ("Toplam tutar: {0}", tutar);
		}
	}
}
