using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_2
{
    class Program
    {

        private static void m1(string v1, int v2, int v3)
        {
            if ((v2 + v3) > 20)
            {
                Console.WriteLine(v1 + " sum: " + (v2 + v3));
            }
            else
            {
                Console.WriteLine("Sorry but sum = " + (v2 + v3));
            }
        }

        private static void m1(string v1, int v2, int v3, int v4)
        {
            if ((v2 + v3 + v4) > 20)
            {
                Console.WriteLine(v1 + " sum: " + (v2 + v3 + v4));
            }
            else
            {
                Console.WriteLine("Sorry but sum = " + (v2 + v3 + v4));
            }
        }

        static void Main(string[] args)
        {
            m1("m1__1", 10, 5, 2);
            m1("m1__2", 5, 5, 8);
            m1("m1__3", 10, 9, 2);
            m1("m1__4", 20, 9);
            Console.Read();
        }
    }
}
