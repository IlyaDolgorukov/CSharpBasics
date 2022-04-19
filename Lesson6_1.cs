using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public delegate double Fun(double x, double y);

    internal class Lesson6_1
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 6
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region Задание 1

            // Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
            // Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x)

            Console.WriteLine("Работа с функцией a*x^2");
            Table(delegate (double x, double a) { return a * Math.Pow(x, 2); }, 2, 5);

            Console.WriteLine();

            Console.WriteLine("Работа с функцией a*sin(x)");
            Table(delegate (double x, double a) { return a * Math.Sin(x); }, 2, 5);

            #endregion

            Console.ReadLine();
            Console.Clear();
        }

        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }


    }
}
