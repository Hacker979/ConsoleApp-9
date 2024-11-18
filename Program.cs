using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_9
{
    internal class Program
    {
        // Задание 2
        public static void plus()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            // Задание 2
            plus();

            Console.Read();
        }
    }
}
