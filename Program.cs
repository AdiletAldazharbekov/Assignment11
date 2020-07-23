using System;
namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Aldazharbekov", "Adilet", "CS2001", "Programming C#", 1, 35);
            student.Transfer("JS2001", "Programming JS");
            Console.WriteLine("");
            student.Info();
            Console.WriteLine("");
            Console.WriteLine(student.GetFullName());
            Console.WriteLine("");
            student.SetFullName("Familia", "Imya");
            student.Info();

        }
    }
}
