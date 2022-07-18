using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_again_
{
    class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону а  первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b  первого треугольника");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону c  первого треугольника");
            double c1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetSquare(a1, b1, c1);
            Console.WriteLine("Введите сторону а  второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону b  второго треугольника");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону c  второго треугольника");
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetSquare(a2, b2, c2);
            Console.WriteLine("Площадь  первого треугольника  равна {0}", s1);
            Console.WriteLine("Площадь  второго треугольника  равна {0}", s2);
            if (s1 > s2)
            {
                Console.WriteLine("Площадь 1 треугольника больше");
            }
            else
                if (s1 < s2)
            {
                Console.WriteLine("Площадь 2 треугольника больше");
            }
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();
        }
        
        
    }
}
