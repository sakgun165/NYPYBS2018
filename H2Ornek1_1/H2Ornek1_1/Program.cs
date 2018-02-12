using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H2Ornek1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter tuşuna basınız.");
            Console.ReadLine();
            Console.WriteLine("Enter tuşuna basınız.");
            {
                int x = 15;
                Console.WriteLine(x);
            }
            //Console.WriteLine(x);//Hatalı işlem
            {
                int x = 26;
                Console.WriteLine(x);
            }
            String s1 = "Merhaba";
            String s2 = "C#";
            String s3 = s1 + " " + s2;
            Console.WriteLine(s3);

            object o;
            o = 10;
            Console.WriteLine(o.GetType());
            o = "B";
            Console.WriteLine(o.GetType());
            o = 8.78F;
            Console.WriteLine(o.GetType());
            o = false;
            Console.WriteLine(o.GetType());
            o = 5.489M;
            Console.WriteLine(o.GetType());
        }
    }
}
