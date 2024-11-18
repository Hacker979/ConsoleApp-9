using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_9
{
    internal class Program
    {
        // Задание 4
        public static void mnogo()
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            int plus(int a, int b) { return a + b; }
            int min(int a, int b) { return a - b; }
            int proisv(int a, int b) { return a * b; }
            int del(int a, int b) { return a / b; }

            Console.WriteLine($"Сложение: {plus(x, y)}, Вычитание: {min(x, y)}, Умножение: {proisv(x, y)}, Деление: {del(x, y)}");
        }

        static void Main(string[] args)
        {
            // Задание 4
            mnogo();

            Console.Read();
        }
    }
}
