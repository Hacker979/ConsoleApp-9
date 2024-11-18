using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_9
{
    internal class Program
    {
        // Задание 3
        public static void fun()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(12 * a, 2) + 7 * a - 6);
        }

        static void Main(string[] args)
        {
            // Задание 3
            fun();

            Console.Read();
        }
    }
}
