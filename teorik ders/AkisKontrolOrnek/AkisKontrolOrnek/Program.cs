using System;

namespace AkisKontrolOrnek
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x, y;
			Console.Write ("Birinci sayıyı girin: ");
			bool xDonusturme = int.TryParse (Console.ReadLine (), out x);
			Console.Write ("Birinci sayıyı girin: ");
			bool yDonusturme = int.TryParse (Console.ReadLine (), out y);
			if (xDonusturme && yDonusturme) {
				if(x>y)
					Console.WriteLine ("1.sayı büyük");
				else
					Console.WriteLine ("2.sayı büyük");
			}
			else
				Console.WriteLine ("Girdiğiniz değerler sayı değil!");
		}
	}
}
