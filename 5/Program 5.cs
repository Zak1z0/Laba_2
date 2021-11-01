using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, P = 0;
            Console.Write("Введите число: "); N = Convert.ToInt32(Console.ReadLine());
            for (int i = 10; i < 99999; i++) 
            {
                double x, y, z, x3, y3, z3;
                x = i % 10;
                y = (i % 100) / 10;
                z = i / 100;
                if (i > 99)
                {
                    x3 = Math.Pow(x,3);
                    y3 = Math.Pow(y, 3);
                    z3 = Math.Pow(z, 3);
                    if (x3 + y3 + z3 == N) 
                    {
                        P++;
                        Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);
                    }
                }
            }   
            if (P == 0) 
            {
                    Console.WriteLine("No such combinations!");
            }
        }
    }
}
