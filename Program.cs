using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_9
{
    internal class Program
    {
        // Задание 5
        public static void F()
        {
            Console.Write("x1 = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Длина отрезка: {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))}");
        }

        public static void D()
        {
            Console.Write("Введите длину стороны a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Периметр треугольника: {a + b + c}");
        }

        static void Main(string[] args)
        {
            // Задание 5
            F();
            D();

            Console.Read();
        }
    }
}
