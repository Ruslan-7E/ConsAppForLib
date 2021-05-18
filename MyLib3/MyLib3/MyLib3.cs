using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
    public static class MyLib3
    {
       public static double SemiPerim(double ab, double bc, double ac) // Аргументами являются стороны треугольника
        {
            return (ab + bc + ac) / 2;  // вычисляем полупериметр треугольника
        }

        public static double Square(double SemiPerim, double ab, double bc, double ac)
        {
            return Math.Sqrt(SemiPerim * (SemiPerim - ab) * (SemiPerim - bc) * (SemiPerim - ac));  // находим площадь по формуле Герона
        }

        public static double CircleSquare(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);  // вычисляем площадь окружности
        }
    }
}
