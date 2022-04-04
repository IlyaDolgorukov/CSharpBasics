using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Lesson5_3
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Задание 3

            // Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой

            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string str2 = Console.ReadLine();

            if (str1.Equals(str2))
            {
                Console.WriteLine("Строки идентичны");
            }
            else if (IsRearrangingString(str1, str2))
            {
                Console.WriteLine("Одна строка является перестановкой другой");
            }
            else
            {
                Console.WriteLine("Одна строка НЕ является перестановкой другой");
            }

            #endregion

            Console.ReadLine();
            Console.Clear();
        }

        static bool IsRearrangingString(string str1, string str2)
        {
            bool result = true;
            int index;
            StringBuilder resultStr = new StringBuilder(str2);

            for (int i = 0; i < str1.Length; i++)
            {
                index = GetLetterIndex(resultStr, str1[i]);
                if (index != -1)
                {
                    resultStr.Remove(index, 1);
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        static int GetLetterIndex(StringBuilder str, char letter)
        {
            int result = -1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
