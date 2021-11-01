using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; string str; 
            Console.Write("Сколько раз надо разделить? : "); str = Console.ReadLine(); n = Convert.ToInt32(str);
            int[] nums = new int[n];
            int k = 0;
            for (int P = 3;k < n;P +=2)
            {
                nums[k] = P;
                Console.WriteLine("1/" + nums[k] + " ");
                k++;
            }
            
        }
    }
}
