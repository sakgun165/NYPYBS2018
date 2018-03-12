using System;

namespace Dizi4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[][] dizi = new int[3][];
			dizi[0] = new int[] { 1, 2 };
			dizi[1] = new int[] { 3, 4, 5, 6, 7 };
			dizi[2] = new int[] { 8, 9, 0 };
			for (int i = 0; i < dizi.GetLength(0); i++)
				for (int j = 0; j < dizi[i].GetLength(0); j++)
					Console.WriteLine("dizi[{0}][{1}]={2}",i,j,dizi[i][j]);
		}
	}
}
