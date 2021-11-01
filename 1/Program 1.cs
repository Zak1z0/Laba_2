using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x1, x2, x, z1, z2, y1, y2, y3;
            Console.Write("Введите a: ");
            string str = Console.ReadLine(); a = Convert.ToInt32(str);
            Console.Write("Введите b: ");
            str = Console.ReadLine(); b = Convert.ToInt32(str);
            Console.Write("Введите c: ");
            str = Console.ReadLine(); c = Convert.ToInt32(str);
            D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("D = b^2 - 4ac = " + D);
            if (D > 0)
            {
                Console.WriteLine("Так как D > 0, будет 2 корня");
                Console.WriteLine("x1,2 = (-b + √D) / 2 * a");
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);
            }
            else if (D == 0)
            {
                Console.WriteLine("Так как D = 0, будет 1 корень");
                Console.WriteLine("x = (-b + √D) / 2 * a");
                x = (-b + Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("x = " + x);
            }
            else
            {
                z1 = Math.Sqrt(D * (-1));
                z2 = Math.Sqrt(D * (-1));
                y1 = -b / 2 * a;
                y2 = z1 / 2 * a;
                y3 = -z2 / 2 * a;
                Console.WriteLine("x1 = " + y1 + " + "+ y2 + "i; x2 = " + y1 + " + (" + y3 + "i);");
            }
        }
    }
}
