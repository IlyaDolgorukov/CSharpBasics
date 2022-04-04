using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpBasics
{
    internal class Lesson5_1
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Задание 1

            // Создать программу, которая будет проверять корректность ввода логина.
            // Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
            // при этом цифра не может быть первой

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();
            bool[] errors = {false, false, false};
            string[] errorsText =
            {
                "Пароль должен содержать от 2 до 10 символов",
                "Пароль не может начинаться на цифру",
                "Пароль может содержать только буквы латинского алфавита или цифры"
            };
            if (!CheckPassword(password, ref errors))
            {
                Console.WriteLine("Пароль не соответствует требованиям:");
                for (int i = 0; i < errors.Length; i++)
                {
                    if (errors[i])
                    {
                        Console.WriteLine(errorsText[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Отлично! Пароль соответствует требованиям");
            }

            #endregion

            Console.ReadLine();
            Console.Clear();
        }

        static bool CheckPassword(string pass, ref bool[] errors)
        {
            if (pass.Length < 2 || pass.Length > 10)
            {
                errors[0] = true;
            }

            if (char.GetUnicodeCategory(pass[0]) == UnicodeCategory.DecimalDigitNumber)
            {
                errors[1] = true;
            }

            pass = pass.ToLower();

            for (int i = 0; i < pass.Length; i++)
            {
                switch (char.GetUnicodeCategory(pass[i]))
                {
                    case UnicodeCategory.DecimalDigitNumber:
                        break;
                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.LowercaseLetter:
                        if ((int)pass[i] < 97 || (int)pass[i] > 122)
                        {
                            errors[2] = true;
                        }
                        break;
                    default:
                        errors[2] = true;
                        break;
                }
            }

            return !errors[0] && !errors[1] && !errors[2];
        }
    }
}
