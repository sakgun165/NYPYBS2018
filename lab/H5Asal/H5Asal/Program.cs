using System;

namespace H5Asal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Bir sayı girin: ");
			int n = Convert.ToInt32 (Console.ReadLine ());
			//Teorik derste görülen yöntem
			int bt = 0;//Tam bölenlerinin toplamı
			for (int i = 1; i <= n; i++) {
				if (n % i == 0)
					bt += i;
			}
			if (bt == n + 1)
				Console.WriteLine ("{0} asaldır", n);
			else
				Console.WriteLine ("{0} asal değildir", n);
			//Başka bir yöntem
			bool asal=true;//Başlangıçta sayı asal kabul edilir
			for (int i = 2; i < n; i++) {
				if (n%i==0) {//[2,n-1] arasında n'i tam bölen bir sayı
					asal = false;//sayı asal değildir
					break;//[2,n-1] arasında n'i tam bölen bir sayı bulundu, diğerlerine bakmaya gerek yok...
				}
			}
			if (asal)
				Console.WriteLine ("{0} asaldır", n);
			else
				Console.WriteLine ("{0} asal değildir", n);
			
		}
	}
}
