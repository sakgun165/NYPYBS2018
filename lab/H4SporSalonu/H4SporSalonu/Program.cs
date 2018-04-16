using System;

namespace H4SporSalonu
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Pamukkale Üniversitesi Spor Salonu Fiyatlandırma Programı");
			Console.Write ("Paket tipini seçin, 1) Gold 2)Havuz-Islak Zemin 3) Gündüz: ");
			int paket = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Üyelik tipini seçin, 1) Bireysel 2) Aile: ");
			int uyelik = Convert.ToInt32 (Console.ReadLine ());
			int tutar;
			if (paket == 1 && uyelik == 1)
				tutar = 1050;
			else if (paket == 1 && uyelik == 2)
				tutar = 1650;
			else if (paket == 2 && uyelik == 1)
				tutar = 775;
			else if (paket == 2 && uyelik == 2)
				tutar = 1100;
			else if (paket == 3 && uyelik == 1)
				tutar = 650;
			else
				tutar = 850;
			Console.WriteLine ("Tutar: {0}", tutar);
		}
	}
}
