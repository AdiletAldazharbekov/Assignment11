using System;
using System.Collections.Generic;

namespace Assignment11
{
    public class Student
    {
        private string FIO { get; set; }
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string MiddleName { get; private set; }
        public string DateOfBirth { get; private set; }
        public int Age { get; private set; }
        public string Gender {get; private set; }
        public string Faculty { get; private set; }
        public int Course { get; private set; }
        public string Group { get; private set; }
       


    public Student()
        {
        }
        
        public Student(string surname, string name, string middleName, string dateOfBirth, int age, string gender, string faculty, int course, string group)
        {
            FIO = $"{surname} {name} {middleName}";
            Surname = surname;
            Name = name;
            MiddleName = middleName;
            DateOfBirth = dateOfBirth;
            Age = age;
            Gender = gender;
            Faculty = faculty;
            Course = course;
            Group = group;
        }

        public void SetFullName(string surname, string name, string middleName)
        {
            FIO = $"{surname} {name} {middleName}";
            Surname = surname;
            Name = name;
            MiddleName = middleName;
        }

        public string GetFullName ()
        {
            return FIO;
        }

        public void Info()
        {
            Console.WriteLine($"\tДанные стурдента\n" +
                $"\nФИО:\t\t{FIO}" +
                $"\nДата рождения:\t{DateOfBirth}" +
                $"\nВозраст:\t{Age}" +
                $"\nПол:\t\t{Gender}" +
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
