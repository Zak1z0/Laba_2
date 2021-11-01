using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите чило: "); N = Convert.ToInt32(Console.ReadLine());
            while (N < 1 | N > 100)
            {
                Console.WriteLine("Введите число больше 1 и меньше 100");
                N = Convert.ToInt32(Console.ReadLine());
            }
            if (N > 4 && N < 21)
            {
                Console.WriteLine(N + " Лет");
            }
            else if (N % 10 == 1)
            {
                Console.WriteLine(N + " Год");
            }
            else if (N % 10 > 1 && N % 10 < 5)
            {
                Console.WriteLine(N + " Года");
            }
            else
            {
                Console.WriteLine(N + " Лет");
            }
        }
    }
}
