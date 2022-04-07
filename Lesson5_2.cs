using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Lesson5_2
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Задание 2

            // Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            // а) Вывести только те слова сообщения, которые содержат не более n букв.
            // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            // в) Найти самое длинное слово сообщения.
            // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

            string message = "За окном потоп, а я ем торт.";

            Console.WriteLine($"Исходная строка: {message}");

            int len = 4;
            Console.WriteLine($"Выводим слова, которые содержат не более {len} букв:");
            Message.PrintMaxLengthWords(message, len);

            char letter = 'м';
            string cutMessage = Message.CutSomeWords(message, letter);
            Console.WriteLine($"Строка, из которой были вырезаны слова, оканчивающиеся на букву '{letter}':");
            Console.WriteLine(cutMessage);

            Message.PrintMaxLengthWord(message);

            Message.PrintMaxLengthWordsString(message, len);

            #endregion

            Console.ReadLine();
            Console.Clear();
        }
    }

    static class Message
    {
        static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-" };

        public static void PrintWords(string message)
        {
            string[] words = GetWords(message);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3 && words[i][0] == words[i][words[i].Length - 1])
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

        public static string[] GetWords(string message)
        {
            return message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        public static void PrintMaxLengthWords(string message, int length)
        {
            string[] words = GetWords(message);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= length)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }

        public static string CutSomeWords(string message, char letter)
        {
            string[] words = GetWords(message);
            string[] result = new string[words.Length];
            int index = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length -1] != letter)
                {
                    result[index] = words[i];
                    index++;
                }
            }

            return string.Join(" ", result);
        }

        public static void PrintMaxLengthWord(string message)
        {
            string[] words = GetWords(message);
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > result.Length)
                {
                    result = words[i];
                }
            }

            Console.WriteLine($"Самое длинное слово: {result}");
        }

        public static void PrintMaxLengthWordsString(string message, int minLength)
        {
            string[] words = GetWords(message);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= minLength)
                {
                    result.Append(words[i] + " ");
                }
            }

            Console.WriteLine($"Строка, составленная из слов, состоящих не менее чем из {minLength} букв:");
            Console.WriteLine(result);
        }
    }
}
