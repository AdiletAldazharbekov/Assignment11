using System;

namespace Assignment11
{
    public class Student
    {
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Group { get; private set; }
        public string Faculty { get; private set; }
        public int Course { get; private set; }
        public int Age { get; private set; }


        public Student()
        {//Добавить пустой конструктор

        }
        
        public Student(string surname, string name, string group, string faculty, int course, int age)
        {//Добавить полный конструктор
            Surname = surname;
            Name = name;
            Group = group;
            Faculty = faculty;
            Course = course;
            Age = age;

            Info();
        }

        public void SetFullName(string surname, string name)
        {//Меняет ФИО студента, если значение пустое вывести ошибку в консоль
            Surname = surname;
            Name = name;
        }

        public string GetFullName ()
        {//Возвращает ФИО студента
            var fullName = $"{Surname} {Name}";
            return fullName;
        }
        public void Info()
        {//Показывает полную информацию о студенте
            Console.WriteLine($"\tДанные стурдента\n" +
                $"\nФамилия:\t{Surname}" +
                $"\nИмя:\t\t{Name}" +
                $"\nГруппа:\t\t{Group}" +
                $"\nФакультет:\t{Faculty}" +
                $"\nКурс:\t\t{Course}" +
                $"\nВозраст:\t{Age}");
        }

        public void Transfer(string group, string faculty)
        {//Переводит студента в другую группу и факультет, если значение пустое вывести ошибку в консоль
            Group = group;
            Faculty = faculty;
        }
    }
}
