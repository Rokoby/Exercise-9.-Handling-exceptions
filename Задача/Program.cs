using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите целое число:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:" +
                "\n1 - сложение" +
                "\n2 - вычитание" +
                "\n3 - произведение" +
                "\n4 - частное");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваш выбор - {0}", c);
                if (c == 1)
                {
                    Console.WriteLine("Результат - {0}", a + b);
                }
                else
                if (c == 2)
                {
                    Console.WriteLine("Результат - {0}", a - b);
                }
                else
                if (c == 3)
                {
                    Console.WriteLine("Результат - {0}", a * b);
                }
                else
                if (c == 4)
                {
                    try
                    {
                        Console.WriteLine("Результат - {0:F2}", (double)a / b);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                Console.WriteLine("Неверный тип операции");
            }   
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
