using System;
using System.Collections.Generic;

namespace Assignment11
{
    public class Student
    {
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; } = 18;
        public string Faculty { get; private set; }
        public int Course { get; private set; } = 1;
        public string Group { get; private set; }
        private string FIO { get; set; }


    public Student()
        {
        }
        
        public Student(string surname, string name, int age, string faculty, int course, string group)
        {
            Surname = surname;
            Name = name;
            Age = age;
            Faculty = faculty;
            Course = course;
            Group = group;
            FIO = $"{surname} {name}";
        }

        public void SetFullName(string surname, string name)
        {
            Surname = surname;
            Name = name;
            FIO = $"{surname} {name}";
        }

        public string GetFullName ()
        {
            return FIO;
        }

        public void Info()
        {
            Console.WriteLine($"\tДанные стурдента {FIO}\n" +
                $"\nФамилия:\t{Surname}" +
                $"\nИмя:\t\t{Name}" +
                $"\nВозраст:\t{Age}" +
                $"\nФакультет:\t{Faculty}" +
                $"\nКурс:\t\t{Course}" +
                $"\nГруппа:\t\t{Group}");
        }

        public void Transfer(string faculty, string group)
        {
            Faculty = faculty;
            Group = group;
        }
    }
}
