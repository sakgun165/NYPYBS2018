using System;

namespace Islem1IO
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 5 * 4 / 6;
			Console.WriteLine (i);

			i = 5 * (4 / 6);
			Console.WriteLine (i);

			int i1 = 5 / 4;
			float f1 = 5 / 4;
			float f2 = 5 / 4f;

			Console.WriteLine (i1);
			Console.WriteLine (f1);
			Console.WriteLine (f2);
		}
	}
}
