using System;

namespace H5TekCiftToplam
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int ctoplam = 0, ttoplam = 0;
			Console.WriteLine ("Bir sayı girin: ");
			int n = Convert.ToInt32 (Console.ReadLine ());
			for (int i = 0; i <= n; i++) {//n dahil
				if (i % 2 == 0)
					ctoplam += i;
				else
					ttoplam += i;
			}
			Console.WriteLine ("Tek toplam={0}, Çift toplam={1}",ttoplam,ctoplam);
		}
	}
}
