using System;

namespace Dizi6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Aralarında boşluk bırakarak sayıları girin: ");
			string sayilar = Console.ReadLine ();
			string[] s=sayilar.Split (' ');
			int [] dizi=new int[s.Length];
			for (int i = 0; i < s.Length; i++) {
				dizi [i] = Convert.ToInt32 (s [i]);
			}
			foreach (int eleman in dizi) {
				Console.WriteLine (eleman);
			}
		}
	}
}
