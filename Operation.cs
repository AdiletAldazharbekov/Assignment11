using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment11
{
    static class Operation
    {
        public static Array Registration()
        {
            Console.WriteLine("\n\tРегистрация студента, введите следующие данные");
            string[] fields = new string[] { "Фамилия", "Имя", "Возраст", "Факультет", "Курс", "Группа" };
            for (int i = 0; i < fields.Length; i++)
            {
                while (true)
                {
                    Console.Write($"{fields[i]}: ");
                    var input = Console.ReadLine();
                    if (Check(input))
                    {
                        fields[i] = input;
                        break;
                    }
                }
            }
            Console.Clear();
            return fields;
        }

        public static Array ChangeFio(string surname, string name)
        {
            Console.WriteLine("\tИзменить Фамилию и Имя студента");
            string[] fio = new string[] { surname, name };
            string[] fio1 = new string[] { "Фамилия", "Имя" };
            for (int i = 0; i < fio1.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"{fio1[i]} в базе: {fio[i]}, поменять на");
                    Console.Write($"{fio1[i]}: ");
                    var input = Console.ReadLine();
                    if (Check(input))
                    {
                        fio1[i] = input;
                        break;
                    }
                }
            }
            Console.Clear();
            return fio1;
        }

        public static Array ChangeFacultyGroup(string faculty, string group)
        {
            Console.WriteLine("\tИзменить Факультет и Группу студента");
            string[] facultyGroup = new string[] { faculty, group };
            string[] facultyGroup1 = new string[] { "Факультет", "Группа" };
            for (int i = 0; i < facultyGroup1.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"{facultyGroup1[i]} в базе: {facultyGroup[i]}, поменять на");
                    Console.Write($"{facultyGroup1[i]}: ");
                    var input = Console.ReadLine();
                    if (Check(input))
                    {
                        facultyGroup1[i] = input;
                        break;
                    }
                }
            }
            Console.Clear();
            return facultyGroup1;
        }

        public static bool Check(string Input)
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз");
                return false;
            }
            return true;
        }
    }
}
