using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment11
{
    class Student
    {
        string Name;
        string Surname;
        string Group;
        string Faculty;
        int Course;
        int Age;

        public Student(string name, string surname, string group, string faculty, int course, int age)
        {
            Name=name;
            Surname=surname;
            Group = group;
            Faculty=faculty;
            Course=course;
            Age=age;
        }

    }
}
