using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpBasics
{
    class Student
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string univercity { get; set; }
        public string faculty { get; set; }
        public string department { get; set; }
        public int age { get; set; }
        public int сourse { get; set; }
        public int group { get; set; }
        public string city { get; set; }

        public void Print()
        {
            Console.WriteLine($"{firstName} {secondName}, {age} лет, г. {city}; {univercity}, {faculty}, {department} {сourse} курс");
        }
    }

    class StudentsFrequency
    {
        public int course { get; set; }
        public int count { get; set; }

        public StudentsFrequency(int crs, int cnt)
        {
            course = crs;
            count = cnt;
        }

        public void Print()
        {
            Console.WriteLine($"На {course}м курсе количество студентов: {count}");
        }
    }

    internal class Lesson6_3
    {
        /// <summary>
        /// Долгоруков Илья. ДЗ 6
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region Задание 3

            // Переделать программу Пример использования коллекций для решения следующих задач:
            // а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            // б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
            // в) отсортировать список по возрасту студента;

            List<Student> students = LoadFile("students.csv");

            int count1 = CountStudents(students, delegate (Student student) {
                return student.сourse == 5 || student.сourse == 6;
            });
            Console.WriteLine($"Количество студентов учащихся на 5 и 6 курсах: {count1}");

            Console.WriteLine();
            List<StudentsFrequency> frequencies = CreateStudentsFrequencyList(students, delegate (Student student) {
                return student.age >= 18 && student.age <= 20;
            });
            frequencies.Sort(new Comparison<StudentsFrequency>(CompareFrequencies));
            Console.WriteLine("Количество студентов в возрасте от 18 до 20 лет по курсам:");
            PrintFrequencies(frequencies);

            Console.WriteLine();
            Console.WriteLine("Список студентов, отсортированный по возрасту:");
            students.Sort(new Comparison<Student>(CompareStudents));
            PrintStudents(students);

            #endregion

            Console.ReadLine();
            Console.Clear();
        }

        public delegate bool IsMatch(Student student);

        public static int CountStudents(List<Student> students, IsMatch F)
        {
            int count = 0;

            foreach (Student student in students)
            {
                if (F(student))
                {
                    count++;
                }
            }

            return count;
        }

        public static List<StudentsFrequency> CreateStudentsFrequencyList(List<Student> students, IsMatch F)
        {
            List<StudentsFrequency> frequencyList = new List<StudentsFrequency>();

            foreach (Student student in students)
            {
                if (F(student))
                {
                    AddStudentToList(student, ref frequencyList);
                }
            }

            return frequencyList;
        }

        public static void AddStudentToList(Student student, ref List<StudentsFrequency> frequencies)
        {
            bool exists = false;

            foreach (StudentsFrequency frequency in frequencies)
            {
                if (frequency.course == student.сourse)
                {
                    frequency.count++;
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                frequencies.Add(new StudentsFrequency(student.сourse, 1));
            }
        }

        public static int CompareFrequencies(StudentsFrequency sf1, StudentsFrequency sf2)
        {
            if (sf1.course == sf2.course)
            {
                return 0;
            }

            return sf1.course > sf2.course ? 1 : -1;
        }

        public static void PrintFrequencies(List<StudentsFrequency> frequencies)
        {
            foreach (StudentsFrequency frequency in frequencies)
            {
                frequency.Print();
            }
        }

        public static int CompareStudents(Student st1, Student st2)
        {
            if (st1.age == st2.age)
            {
                return 0;
            }

            return st1.age > st2.age ? 1 : -1;
        }

        public static List<Student> LoadFile(string fileName)
        {
            List<Student> students = new List<Student>();
            StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + fileName);
            while (!reader.EndOfStream)
            {
                string[] line = reader.ReadLine().Split(';');
                Student student = new Student();
                student.firstName = line[0];
                student.secondName = line[1];
                student.univercity = line[2];
                student.faculty = line[3];
                student.department = line[4];
                student.age = int.Parse(line[5]);
                student.сourse = int.Parse(line[6]);
                student.group = int.Parse(line[7]);
                student.city = line[8];
                students.Add(student);
            }

            return students;
        }

        public static void PrintStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                student.Print();
            }
        }
    }
}
