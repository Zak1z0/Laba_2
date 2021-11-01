using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Day, Month, Year; string str;
            Console.Write("Введите число: "); str = Console.ReadLine(); Day = Convert.ToInt32(str);
            Console.Write("Введите месяц: "); str = Console.ReadLine(); Month = Convert.ToInt32(str);
            Console.Write("Введите год: "); str = Console.ReadLine(); Year = Convert.ToInt32(str);
            if (Day < 10 && Month < 10)
            {
                Console.WriteLine("0" + Day + "/" + "0" + Month + "/" + Year);
            }
            else if (Month < 10)
            {
                Console.WriteLine(Day + "/" + "0" + Month + "/" + Year);
            }
            else if (Day < 10)
            {
                Console.WriteLine("0" + Day + "/" + Month + "/" + Year);
            }
            else
            {
                Console.WriteLine(Day + "/" + Month + "/" + Year);
            }
        }
    }
}
