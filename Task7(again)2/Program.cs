using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_again_2
{
    class Program
    {
        static void GetParamCube(double a, out double s, out double v)
        {
            s = 6.0 * a * a;
            v = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону");
            double a = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamCube(a, out s, out v);
            Console.WriteLine("Площадь поверхности куба равна {0:.00}, Объем куба равен {1:.00}", s, v);
            Console.ReadKey();
        
        }
    }
}
