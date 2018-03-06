using System;

namespace AkisKontrol2IO
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int not;
			Console.Write ("Notunuzu girin: ");
			not = Convert.ToInt32 (Console.ReadLine ());

			if(not>=0 && not<40)
				Console.WriteLine ("F");
			else if(not>=40 && not<50)
				Console.WriteLine ("E");
			else if(not>=50 && not<55)
				Console.WriteLine ("D2");
			else if(not>=55 && not<60)
				Console.WriteLine ("D1");
			else if(not>=60 && not<65)
				Console.WriteLine ("C2");
			else if(not>=65 && not<70)
				Console.WriteLine ("C1");
			else if(not>=70 && not<75)
				Console.WriteLine ("B2");
			else if(not>=75 && not<80)
				Console.WriteLine ("B1");
			else if(not>=80 && not<90)
				Console.WriteLine ("A2");
			else if(not>=90 && not<=100)
				Console.WriteLine ("A1");
			else
				Console.WriteLine ("Lütfen aralıkta bir değer girin!");
		}
	}
}
