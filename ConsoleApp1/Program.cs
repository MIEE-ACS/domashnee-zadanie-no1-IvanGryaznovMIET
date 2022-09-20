using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите точку А: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите точку B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите точку C: ");
            double C = double.Parse(Console.ReadLine());
            if ( A < B && B > C && A < C)
            {
                double AB = B - A;
                double AC = C - A;
                double CB = B - C;
                Console.WriteLine($"Отрезок АС: {AC:0.00}");
                Console.WriteLine($"Отрезок СВ: {CB:0.00}");
                Console.WriteLine($"Отрезок AC + CB: {AB:0.00}");
            }
            else
            {
                Console.Write("Данные не корректные! Консоль закрывается.");
            }
            Console.ReadLine();     
        }
    }
}
