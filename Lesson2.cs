using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Lesson2
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Задание 1

            // Написать метод, возвращающий минимальное из трёх чисел

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());

            int min = GetMin(a, b, c);
            Console.WriteLine($"Минимальное число: {min}");

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 2

            // Написать метод подсчета количества цифр числа

            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            int count = CountNumbers(x);
            Console.WriteLine($"Количество цифр числа: {count}");

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 3

            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел

            int sum = CountSum();
            Console.WriteLine($"Сумма нечетных положительных чисел: {sum}");

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 4

            // Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains)
            // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
            // программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками

            int attempts = 1;
            bool loggedIn = false;

            do
            {
                Console.Clear();
                Console.Write("Логин: ");
                string login = Console.ReadLine();

                Console.Write("Пароль: ");
                string passwd = Console.ReadLine();

                if (hasAccess(login, passwd)) {
                    Console.WriteLine($"Добро пожаловать {login}");
                    loggedIn = true;
                    break;
                }
                else if (attempts < 3)
                {
                    Console.WriteLine("Не верный логин или пароль");
                    Console.WriteLine($"Осталось попыток: {3 - attempts}");
                    Console.ReadLine();
                }

                attempts++;
            } while (attempts < 4);

            if (!loggedIn) 
            {
                Console.WriteLine("Доступ закрыт.");
            }

            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Задание 5

            // Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
            // нужно ли человеку похудеть, набрать вес или всё в норме

            GetMassIndex();

            Console.ReadLine();
            Console.Clear();

            #endregion

        }

        static int GetMin(int a, int b, int c)
        {
            int min = a;

            if (b < min)
            {
                min = b;
            }

            if (c < min)
            {
                min = c;
            }

            return min;
        }

        static int CountNumbers(int number)
        {
            string str = number.ToString();

            return str.Length;
        }

        static int CountSum()
        {
            int sum = 0, count = 1, num = 1;

            do
            {
                Console.Write("Введите число (для завершения введите 0): ");
                num = int.Parse(Console.ReadLine());
                if (!isEven(count) && num > 0)
                {
                    sum += num;
                }
                count++;

            } while (num != 0);

            return sum;
        }

        static bool isEven(int x)
        {
            return x % 2 == 0;
        }

        static bool hasAccess(string login, string passwd)
        {
            return login == "root" && passwd == "GeekBrains";
        }

        static void GetMassIndex()
        {
            Console.Write("Введите Ваш рост в метрах: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Введите Ваш вес в килограммах: ");
            double weight = double.Parse(Console.ReadLine());

            double index = weight / (height * height);

            double min = 18.5;
            double max = 25;

            if (index < min)
            {
                Console.WriteLine("У Вас недостаток веса");
                Console.WriteLine($"Индекс массы тела {index:F2} при норме от {min} до {max}");
                Console.WriteLine($"Необходимо набрать минимум {GetTargetWeight(height, weight, min):F2} кг");
            }
            else if (index > max)
            {
                Console.WriteLine("У Вас избыток веса");
                Console.WriteLine($"Индекс массы тела {index:F2} при норме от {min} до {max}");
                Console.WriteLine($"Необходимо сбросить минимум {GetTargetWeight(height, weight, max):F2} кг");
            }
            else
            {
                Console.WriteLine("Поздравляем! У Вас все хорошо");
                Console.WriteLine($"Индекс массы тела {index:F2} при норме от {min} до {max}");
            }
        }

        static double GetTargetWeight(double height, double weight, double target)
        {
            double targetWeight = target * height * height;

            return Math.Abs(weight - targetWeight);
        }
    }
}
