using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment11
{
    static class Operation
    {
        public static int MainOperation()
        {
            Console.WriteLine("Выберите операцию" +
                "\n\t1. Просмотр данных студента" +
                "\n\t2. Просмотр ФИО студента" +
                "\n\t3. Поменять ФИО студента" +
                "\n\t4. Перевод студента" +
                "\n\tВыход любая другая клавиша");
            
            var input = Console.ReadLine();
            int.TryParse(input, out int oper);
            Console.Clear();
            return oper;
        }



        public static Array Registration()
        {
            Console.WriteLine("\n\tДля регистрации студента, введите следующие данные");
            string[] fields = new string[] { "Фамилия", "Имя", "Отчество", "Дата рождения", "Возраст","Пол", "Факультет", "Курс", "Группа" };
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

        public static Array ChangeFio(string surname, string name, string middleName)
        {
            Console.WriteLine("\tИзменить Фамилию, Имя и Отчество студента\n");
            string[] fio = new string[] { surname, name, middleName };
            string[] fio1 = new string[] { "Фамилия", "Имя", "Отчество" };
            for (int i = 0; i < fio1.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"{fio1[i]}: {fio[i]}");
                    Console.Write("поменять на: ");
                    var input = Console.ReadLine();
                    if (Check(input))
                    {
                        fio1[i] = input;
                        Console.WriteLine("");
                        break;
                    }
                }
            }
            Console.Clear();
            return fio1;
        }

        public static Array ChangeFacultyGroup(string faculty, string group)
        {
            Console.WriteLine("\tИзменить Факультет и Группу студента\n");
            string[] facultyGroup = new string[] { faculty, group };
            string[] facultyGroup1 = new string[] { "Факультет", "Группа" };
            for (int i = 0; i < facultyGroup1.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"{facultyGroup1[i]}: {facultyGroup[i]}");
                    Console.Write("поменять на: ");
                    var input = Console.ReadLine();
                    if (Check(input))
                    {
                        facultyGroup1[i] = input;
                        Console.WriteLine("");
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
                Console.WriteLine("Ошибка, вы ввели пустую строку\n");
                return false;
            }
            return true;
        }
    }
}
