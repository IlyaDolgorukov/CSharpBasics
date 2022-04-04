using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    struct Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Plus(Complex complex)
        {
            Complex newComplex;
            newComplex.re = re + complex.re;
            newComplex.im = im + complex.im;
            return newComplex;
        }

        public static Complex Plus(Complex complex1, Complex complex2)
        {
            Complex newComplex;
            newComplex.re = complex1.re + complex2.re;
            newComplex.im = complex1.im + complex2.im;
            return newComplex;
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Minus(Complex complex)
        {
            Complex newComplex;
            newComplex.re = re - complex.re;
            newComplex.im = im - complex.im;
            return newComplex;
        }

        public static Complex Minus(Complex complex1, Complex complex2)
        {
            Complex newComplex;
            newComplex.re = complex1.re - complex2.re;
            newComplex.im = complex1.im - complex2.im;
            return newComplex;
        }

        public override string ToString()
        {
            base.ToString();
            return $"{re} + {im}i";
        }

    }

    class ComplexV2
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        public ComplexV2(double newRe, double newIm)
        {
            im = newIm;
            re = newRe;
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexV2 Plus(ComplexV2 complex)
        {
            return new ComplexV2(re + complex.re, im + complex.im);
        }

        public static ComplexV2 Plus(ComplexV2 complex1, ComplexV2 complex2)
        {
            return new ComplexV2(complex1.re + complex2.re, complex1.im + complex2.im);
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexV2 Minus(ComplexV2 complex)
        {
            return new ComplexV2(re - complex.re, im - complex.im);
        }

        public static ComplexV2 Minus(ComplexV2 complex1, ComplexV2 complex2)
        {
            return new ComplexV2(complex1.re - complex2.re, complex1.im - complex2.im);
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexV2 Multiply(ComplexV2 complex)
        {
            return new ComplexV2(re * complex.re, im * complex.im);
        }

        public static ComplexV2 Multiply(ComplexV2 complex1, ComplexV2 complex2)
        {
            return new ComplexV2(complex1.re * complex2.re, complex1.im * complex2.im);
        }

        public override string ToString()
        {
            base.ToString();
            return $"{re} + {im}i";
        }

    }

    internal class Lesson3
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 3
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Задание 1.а

            // Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.

            Complex complex01;
            complex01.re = 2;
            complex01.im = 3;

            Complex complex02;
            complex02.re = 0;
            complex02.im = -2;

            Console.WriteLine(complex01);
            Console.WriteLine(complex02);

            Complex complex03 = complex02.Plus(complex01);

            Console.WriteLine($"Результат сложения комплексных чисел {complex01} и {complex02} : {complex03}");

            Complex complex04 = Complex.Plus(complex02, complex01);

            Console.WriteLine($"Результат сложения комплексных чисел {complex01} и {complex02} : {complex04}");

            Complex complex05 = complex01.Minus(complex02);

            Console.WriteLine($"Результат вычитания комплексных чисел {complex01} и {complex02} : {complex05}");

            Complex complex06 = Complex.Minus(complex01, complex02);

            Console.WriteLine($"Результат вычитания комплексных чисел {complex01} и {complex02} : {complex06}");

            #endregion

            Console.WriteLine();

            #region Задание 1.б

            // Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

            ComplexV2 complex001 = new ComplexV2(2, 4);
            ComplexV2 complex002 = new ComplexV2(1, -5);

            ComplexV2 complex003 = complex002.Plus(complex001);

            Console.WriteLine($"Результат сложения комплексных чисел {complex001} и {complex002} : {complex003}");

            ComplexV2 complex004 = ComplexV2.Plus(complex002, complex001);

            Console.WriteLine($"Результат сложения комплексных чисел {complex001} и {complex002} : {complex004}");

            ComplexV2 complex005 = complex002.Minus(complex001);

            Console.WriteLine($"Результат вычитания комплексных чисел {complex001} и {complex002} : {complex005}");

            ComplexV2 complex006 = ComplexV2.Minus(complex002, complex001);

            Console.WriteLine($"Результат вычитания комплексных чисел {complex001} и {complex002} : {complex006}");

            ComplexV2 complex007 = complex002.Multiply(complex001);

            Console.WriteLine($"Результат умножения комплексных чисел {complex001} и {complex002} : {complex007}");

            ComplexV2 complex008 = ComplexV2.Multiply(complex002, complex001);

            Console.WriteLine($"Результат умножения комплексных чисел {complex001} и {complex002} : {complex008}");

            #endregion

            Console.ReadLine();
            Console.Clear();

            #region Задание 1.в

            // Добавить диалог с использованием switch демонстрирующий работу класса.

            int num = 1;
            string action = "";
            ComplexV2 complexTmp = new ComplexV2(0, 0);

            do
            {
                Console.Write("Что вы хотите сделать? (1 - сложить, 2 - вычесть, 3 - умножить): ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1: 
                        complexTmp = ComplexV2.Plus(complex002, complex001);
                        action = "сложения";
                        break;
                    case 2:
                        complexTmp = ComplexV2.Minus(complex002, complex001);
                        action = "вычитания";
                        break;
                    case 3:
                        complexTmp = ComplexV2.Multiply(complex002, complex001);
                        action = "умножения";
                        break;
                    default:
                        num = 0;
                        break;
                }
                if (num != 0)
                {
                    ShowResult(complex002, complex001, complexTmp, action);
                }
            } while (num != 0);

            #endregion

            Console.ReadLine();
            Console.Clear();

            #region Задание 2

            // С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
            // Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран,
            // используя tryParse.

            CountSum();

            #endregion

            Console.ReadLine();
            Console.Clear();
        }

        static void ShowResult(ComplexV2 complex1, ComplexV2 complex2, ComplexV2 complex3, string action)
        {
            Console.WriteLine($"Результат {action} комплексных чисел {complex1} и {complex2} : {complex3}");
        }

        static void CountSum()
        {
            int sum = 0, count = 1, num;
            bool flag;
            string numbers = "";

            do
            {
                Console.Write("Введите число (для завершения введите 0): ");
                flag = int.TryParse(Console.ReadLine(), out num);
                if (flag)
                {
                    if (!IsEven(count) && num > 0)
                    {
                        sum += num;
                        numbers += (numbers.Length > 0 ? " + " : "") + num;
                    }
                    count++;
                } 
                else
                {
                    num = 1;
                }
            } while (num != 0);

            Console.WriteLine($"{numbers} = {sum}");
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
