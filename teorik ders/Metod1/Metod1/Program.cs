using System;

namespace Metod1
{
	class MainClass
	{
		static int topla(int a, int b)
		{
			return a + b;
		}

		static void yaz(object o)
		{
			Console.WriteLine (o.ToString());
		}

		static int buyukBul(int a, int b)
		{
			int donen;
			if (a > b)
				donen=a;
			else
				donen=b;

			a = 0;
			b = 0;
			return donen;
		}

		static int buyukBul3(int a,int b, int c)
		{
			return buyukBul (a, buyukBul (b, c));
		}

		static void referansTipiAktarim(int[] dizi)
		{
			dizi [0] = 30;
		}
		
		public static void Main (string[] args)
		{
			int sonuc = topla (15, 7);
			Console.WriteLine (sonuc);
			Console.WriteLine (topla (21, 18));
			yaz ("\n");
			yaz (3 + 5);
			yaz (3.5f + 4.6f);
			Console.Write ("Birinci sayı: ");
			int s1 = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("İkinci sayı: ");
			int s2 = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("Büyük sayı: {0}", buyukBul (s1, s2));
			Console.WriteLine (s1);
			Console.WriteLine (s2);

			int[] d = new int[]{ 100, 200 };
			Console.WriteLine (d[0]);
			referansTipiAktarim (d);
			Console.WriteLine (d[0]);

		}
	}
}
