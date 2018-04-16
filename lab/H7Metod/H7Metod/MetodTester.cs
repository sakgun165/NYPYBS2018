using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H7Metod
{
    class MetodTester
    {
        static void comment(string comment)
        {
            Console.WriteLine("<|--");
            Console.WriteLine(comment);
            Console.WriteLine("--|>");
        }
        static void Main()
        {
            int not = 0;
            int dogru = 0;
            double komisyon50=-1;
            double komisyon170=-1;
            try
            {
                komisyon50=MetodWorking.komisyonUcreti(50);
                komisyon170=MetodWorking.komisyonUcreti(170);
                dogru++;
            }
            catch (Exception)
            {
                comment("Komisyon ücreti metodu hatalı");
            }
            if (komisyon50 == Metodlar.komisyonUcreti(50))
                dogru++;
            else
                comment("50 TL için komisyon hesaplama hatalı");
            if (komisyon170 == Metodlar.komisyonUcreti(170))
                dogru++;
            else
                comment("170 TL için komisyon hesaplama hatalı");

        }
    }
}
