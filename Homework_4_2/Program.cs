using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_2
{
    class Program
    {

        private static void m1(string str, params int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            if (sum > 20)
            {
                Console.WriteLine(str + " Sum = " + (sum));
            }
            else
            {
                Console.WriteLine("Sorry but sum = " + (sum));
            }
        }

        static void Main(string[] args)
        {
            m1("string", 2, 9, 5, 1, 1, 1, 1);
            Console.Read();
        }
    }
}
