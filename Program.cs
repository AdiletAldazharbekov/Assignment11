using System;

namespace Assignment11
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа учета студентов");

            var fields = (string[])Operation.Registration();
            Student student = new Student(fields[0], fields[1], fields[2], fields[3], Convert.ToInt32(fields[4]), fields[5], fields[6], Convert.ToInt32(fields[7]), fields[8]);

            while (true)
            {
                var input = Operation.MainOperation();

                switch (input)
                {
                    case 1:
                        student.Info();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("ФИО: ");
                        Console.WriteLine(student.GetFullName());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        var fio = (string[])Operation.ChangeFio(student.Surname, student.Name, student.MiddleName);
                        student.SetFullName(fio[0], fio[1], fio[2]);
                        break;
                    case 4:
                        var facultyGroup = (string[])Operation.ChangeFacultyGroup(student.Faculty, student.Group);
                        student.Transfer(facultyGroup[0], facultyGroup[1]);
                        break;
                    default:
                        break;
                }
                if (input == 0) break;
            }

        }
    }
}
