using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndivid_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s=0; string str;
            Console.Write("Введите a: "); str = Console.ReadLine(); a = Convert.ToInt32(str);
            Console.Write("Введите b: "); str = Console.ReadLine(); b = Convert.ToInt32(str);
            while (a >= b)
            {
                Console.WriteLine("a должно быть меньше b");
                Console.WriteLine("Введите снова");
                Console.Write("Введите a: "); str = Console.ReadLine(); a = Convert.ToInt32(str);
                Console.Write("Введите b: "); str = Console.ReadLine(); b = Convert.ToInt32(str);
            }
            if ((a % 2) != 0)
            {
                for (int i = a; i <= b; i += 2)
                {
                    s = s + i;
                    Console.Write(i + " ");
                }
            }
            else if ((a % 2) == 0)
            {
                a += 1;
                for (int i = a; i <= b; i += 2)
                {
                    s = s + i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма нечетных чисел: " + s);
        }
    }
}
