using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int P,n; string str;
            Console.Write("Сколько цифр должно быть в ряде? : "); str = Console.ReadLine(); n = Convert.ToInt32(str);
            int[] row = new int[n];  row[0] = 1; row[1] = 1;
            P = row[0] + row[1];
            Console.Write(row[0] + " " + row[1] + " ");
            for (int k = 2; k < n; k++)
            {
                P = row[k-1] + row[k-2];
                row[k] = P;
                Console.Write(row[k] + " ");
            }
        }
    }
}
