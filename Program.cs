using System;

namespace Assignment11
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа учета студентов\n");

            var fields = (string[])Operation.Registration();
            Student student = new Student(fields[0], fields[1], Convert.ToInt32(fields[2]), fields[3], Convert.ToInt32(fields[4]), fields[5]);
            Console.WriteLine("");

            var fio = (string[])Operation.ChangeFio(student.Surname, student.Name);
            student.SetFullName(fio[0], fio[1]);

            var facultyGroup = (string[])Operation.ChangeFacultyGroup(student.Faculty, student.Group);
            student.Transfer(facultyGroup[0], facultyGroup[1]);

            student.Info();

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(student.GetFullName());
            Console.ReadKey();
        }
        
    }

}
