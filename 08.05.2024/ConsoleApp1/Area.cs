using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Area
    {

        static double TriangleArea(double a, double b, double c)
        {
            // Полупериметр треугольника
            double p = (a + b + c) / 2.0;
            // Формула Герона для площади
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    
}
