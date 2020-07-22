using System;

namespace Assignment11
{
    class Student
    {
        string Surname;
        string Name;
        string Group;
        string Faculty;
        int Course;
        int Age;

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

        void Info()
        {
            Console.WriteLine($"\tДанные стурдента\n" +
                $"\nФамилия:\t{Surname}" +
                $"\nИмя:\t\t{Name}" +
                $"\nГруппа:\t\t{Group}" +
                $"\nФакультет:\t{Faculty}" +
                $"\nКурс:\t\t{Course}" +
                $"\nВозраст:\t{Age}");
        }

        void Transfer()
        {
            Console.WriteLine("");//Перевод студента в другую группу и факультет
        }
    }
}
