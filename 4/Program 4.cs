using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        public static double Facyorial(int i)
        {
            return i == 0 ? 1 : Facyorial(i - 1) * i;
        }
        static void Main(string[] args)
        {
            double q, x;
            Console.Write("Введите число q: "); q = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите переменную x: "); x = Convert.ToDouble(Console.ReadLine());
            if (q > 0)
            {
                double a = 1;
                double c = 1;       int i = 1;
                c = Math.Pow(x, 2) / Facyorial(2);
                while (c >= q)
                {
                    a = i % 2 == 0 ? a + c : a - c;
                    i++;
                    c = Math.Pow(x, i * 2) / Facyorial(2 * i);
                }
                Console.WriteLine("cos(x) = " + a);
                Console.WriteLine("Число задействованых элементов: " + i);
            }
        }
    }
}
