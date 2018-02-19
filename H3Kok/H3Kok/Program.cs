using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H3Kok
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;
            Console.Write("a katsayısını girin: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b katsayısını girin: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c katsayısını girin: ");
            c = Convert.ToDouble(Console.ReadLine());
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("Kök 1={0}", x1);
            Console.WriteLine("Kök 2={0}", x2);
        }
    }
}
