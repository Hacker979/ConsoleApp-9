using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_9
{
    internal class Program
    {
        // Задание 1
        public static void Sayhello()
        {
            Console.WriteLine("привет");
        }

        public static void Saypoka()
        {
            Console.WriteLine("пока");
        }

        static void Main(string[] args)
        {
            // Задание 1
            Sayhello();
            Saypoka();

            Console.Read();
        }
    }
}
