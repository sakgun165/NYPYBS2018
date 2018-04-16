using System;

namespace H4Komisyon
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Havale miktarını girin: ");
			double miktar = Convert.ToDouble (Console.ReadLine ());//Kullanıcıdan bir ondalıklı sayı al
			if (miktar < 100)
				miktar = miktar * 1.01;//miktarın %101'i toplam tutarı verir
			else
				miktar *= 1.02;//100 TL'den fazla ise miktarın %102'si toplam tutarı verir
			Console.WriteLine ("Toplam tutar: {0}", miktar);
		}
	}
}
