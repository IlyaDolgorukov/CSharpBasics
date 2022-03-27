using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Lesson1
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Задание 1

            // Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
            // В результате вся информация выводится в одну строчку

            Profile();
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 2

            // Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
            // где m — масса тела в килограммах, h — рост в метрах

            MassIndex();
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 3

            // Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y
            // по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификато
            // формата .2f (с двумя знаками после запятой)
            GetDistance();
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 4

            // Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов

            // а) с использованием третьей переменной

            Console.Write("Введите целое число A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите целое число B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}, b = {b}");

            // б) *без использования третьей переменной

            Console.Write("Введите целое число A: ");
            int a1 = int.Parse(Console.ReadLine());

            Console.Write("Введите целое число B: ");
            int b1 = int.Parse(Console.ReadLine());

            a1 = a1 + b1;
            b1 = a1 - b1;
            a1 = a1 - b1;

            Console.WriteLine($"a = {a1}, b = {b1}");
            Console.ReadLine();

            #endregion
        }

        static void Profile() 
        {
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string lastname = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите Ваш рост: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите Ваш вес: ");
            int weight = int.Parse(Console.ReadLine());

            ProfileOutput(name, lastname, age, height, weight);
        }

        static void ProfileOutput(string name, string lastname, int age, int height, int weight)
        {
            // а) используя склеивание
            Console.WriteLine("Имя: " + name + ", Фамилия: " + lastname + ", Возраст: " + age + ", Рост: " + height + ", Вес: " + weight);

            // б) используя форматированный вывод
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", name, lastname, age, height, weight);

            // в) используя вывод со знаком $
            Console.WriteLine($"Имя: {name}, Фамилия: {lastname}, Возраст: {age}, Рост: {height}, Вес: {weight}");
        }

        static void MassIndex()
        {
            Console.Write("Введите Ваш рост в метрах: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Введите Ваш вес в килограммах: ");
            double weight = double.Parse(Console.ReadLine());

            double index = weight / (height * height);

            Console.WriteLine($"Ваш индекс массы тела: {index}");
        }

        static void GetDistance()
        {
            Console.Write("Введите координату X первой точки: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y первой точки: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату X второй точки: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y второй точки: ");
            double y2 = double.Parse(Console.ReadLine());

            CalcDistance(x1, y1, x2, y2);
        }

        static void CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками равно: {distance:F2}");
        }
    }
}
