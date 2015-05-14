using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radious: ");
            double radious = Convert.ToDouble(Console.ReadLine());
           // Console.WriteLine();
            Console.WriteLine("Area: " + GetArea(radious));
            Console.WriteLine("perameter: " + GetPerameter(radious));
            Console.ReadKey();

        }

        public static double GetArea(double radious)
        {
            return 3.14 * radious* radious;
        }

       public static double GetPerameter(double radious)
        {
            return 2 * 3.1416 * radious;
        }

    }
}
