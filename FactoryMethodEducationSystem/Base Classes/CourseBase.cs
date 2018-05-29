using System;
using System.Collections.Generic;

namespace FactoryMethodEducationSystem.Base_Classes
{
    public abstract class CourseBase
    {
        private const string PREFIX = "02";
        private static int NumberOfCreatedObject = 0;
        public string ID { get; }
        public string Name { get; set; }
        public List<string> Teachers = new List<string>();
        public List<string> Students = new List<string>();
        protected CourseBase(string name, string[] teachers, string[] students)
        {
            Name = name;
            Teachers.AddRange(teachers);
            Students.AddRange(students);
            ID = PREFIX + NumberOfCreatedObject;
            NumberOfCreatedObject++;
        }
        public void PrintInfoAbout()
        {
            Console.WriteLine("Course ID: " + ID);
            Console.WriteLine("Course Name: " + Name);
            Teachers.ForEach(i => Console.WriteLine("Teacher ID: " + "{0}\t", i));
            Students.ForEach(j => Console.WriteLine("Student ID: " + "{0}\t", j));
            Console.WriteLine(GetType());
            Console.WriteLine();
        }
    }
}
