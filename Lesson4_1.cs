using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Lesson4_1
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 4
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Дан целочисленный массив из 20 элементов.
            // Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно
            // Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива,
            // в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемент
            // массива.

            int[] array = new int[20];

            FillArray(array, -10000, 10000);

            Console.WriteLine("Исходный массив:");

            PrintArray(array);

            int pairs = CountPairs(array);

            Console.WriteLine($"Количество пар, в которых только одно число делится на 3 = {pairs}");

            Console.ReadLine();
            Console.Clear();
        }

        static void FillArray(int[] arr, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max + 1);
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        static int CountPairs(int[] arr)
        {
            int prev, count = 0;
            bool first, second;
            for (int i = 1; i < arr.Length; i++)
            {
                prev = i - 1;
                first = IsMultipleOfThree(arr[prev]);
                second = IsMultipleOfThree(arr[i]);
                if ((first || second) && !(first && second))
                {
                    Console.WriteLine($"В паре {arr[prev]} и {arr[i]}, только {(first ? arr[prev] : arr[i])} делится на 3");
                    count++;
                }
            }

            return count;
        }

        static bool IsMultipleOfThree(int num)
        {
            return num % 3 == 0;
        }
    }
}
