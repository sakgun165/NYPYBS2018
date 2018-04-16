using System;

namespace Metod2
{
	class MainClass
	{
		static void OrnekMetot()
		{
			Console.WriteLine("1.Metot");
		}
		static void OrnekMetot(int x, int y)
		{
			Console.WriteLine("2.Metot");
		}
		static void OrnekMetot(string a, string b)
		{
			Console.WriteLine("3.Metot");
		}
		static void OrnekMetot(int x)
		{
			Console.WriteLine("4.Metot");
		}
		static void OrnekMetot(float x,float y)
		{
			Console.WriteLine("5.Metot");
		}
		public static void Main (string[] args)
		{
			OrnekMetot(56);
			OrnekMetot("Metot", "Yukleme");
			OrnekMetot();
			OrnekMetot(74, 56);
			OrnekMetot(12, 34f);
			OrnekMetot('a', 'e');
			OrnekMetot (55d, 46d);
		}
	}
}
