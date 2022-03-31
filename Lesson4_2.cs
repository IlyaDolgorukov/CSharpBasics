using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Lesson4_2
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 4
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Реализуйте задачу 1 в виде статического класса StaticClass;
            // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            // б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;

            int[] array1 = new int[20];

            StaticClass.FillArray(array1, -10000, 10000);
            StaticClass.ProcessArray(array1);

            Console.WriteLine();

            int[] array2 = StaticClass.ProcessFile("data.txt");
            StaticClass.ProcessArray(array2);

            Console.ReadLine();
            Console.Clear();
        }
    }

    static class StaticClass
    {
        static public int[] ProcessFile(string fileName)
        {
            StreamReader sr = new StreamReader("..\\..\\" + fileName);

            string str;
            int line = 0;
            int[] array = new int[20];

            while (!sr.EndOfStream)
            {
                str = sr.ReadLine();
                if (line < array.Length)
                {
                    array[line] = int.Parse(str);
                }
                line++;
            }
            sr.Close();

            return array;
        }

        static public void ProcessArray(int[] array)
        {
            Console.WriteLine("Исходный массив:");

            PrintArray(array);

            int pairs = CountPairs(array);

            Console.WriteLine($"Количество пар, в которых только одно число делится на 3 = {pairs}");
        }

        static public void FillArray(int[] arr, int min, int max)
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
