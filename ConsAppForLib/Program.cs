using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProj;

namespace ConsAppForLib
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = MyLib3.CircleSquare(7); // Аргументом является радиусом круга
            Console.WriteLine(result1);

            double result2 = MyLib3.SemiPerim(5.5, 6.6, 7.7); // Аргументами являются стороны треугольника
            Console.WriteLine(result2);

            double result3 = MyLib3.Square(9.9, 5.5, 6.6, 7.7); // Аргументами являются полупериметр и стороны треугольника
            Console.WriteLine(result3);
        }
    }
}
