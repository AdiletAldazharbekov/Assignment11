using System;

namespace Assignment11
{
    public class Student
    {
        private string Surname;
        private string Name;
        private string Group;
        private string Faculty;
        private int Course;
        private int Age;
        
        public Student(string surname, string name, string group, string faculty, int course, int age)
        {
            Surname = surname;
            Name = name;
            Group = group;
            Faculty = faculty;
            Course = course;
            Age = age;

            Info();
        }

        public void Info()
        {
            Console.WriteLine($"\tДанные стурдента\n" +
                $"\nФамилия:\t{Surname}" +
                $"\nИмя:\t\t{Name}" +
                $"\nГруппа:\t\t{Group}" +
                $"\nФакультет:\t{Faculty}" +
                $"\nКурс:\t\t{Course}" +
                $"\nВозраст:\t{Age}");
        }

        public void Transfer(string group, string faculty)
        {
            Group = group;
            Faculty = faculty;
        }
    }
}
