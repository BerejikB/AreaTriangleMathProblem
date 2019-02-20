using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_triangle
{
    class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Side A length: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Side B length: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Side C length: ");
            double sideC = double.Parse(Console.ReadLine());

            double P = (sideA + sideB + sideC) / 2;
            double Area = Math.Sqrt((P*(P - sideA)*(P - sideB)*(P - sideC)));
            Console.WriteLine("Area=" + Area);
            Console.ReadKey();



        }
    }
}
