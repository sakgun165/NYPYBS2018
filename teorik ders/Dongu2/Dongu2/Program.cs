using System;

namespace Dongu2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i=0;
			while (i < 1000)
			{
				i += 5;
				Console.Write("{0,5}",i);
				if (i % 50 == 0) Console.WriteLine();
			}
		}
	}
}
