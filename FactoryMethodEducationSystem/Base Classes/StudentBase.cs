using System;
using System.Collections.Generic;

namespace FactoryMethodEducationSystem.Base_Classes
{
    abstract class StudentBase
    {
        private const string PREFIX = "00";
        private static int NumberOfCreatedObject = 0;
        public string ID { get; }
        public string Name { get; set; }
        public List<string> Courses = new List<string>();

        protected StudentBase(string name, string[] courses)
        {
            Name = name;
            Courses.AddRange(courses);
            ID = PREFIX + NumberOfCreatedObject;
            NumberOfCreatedObject++;
        }
        public void PrintInfoAbout()
        {
            Console.WriteLine("Student ID: " + ID);
            Console.WriteLine("Student Name: " + Name);
            Courses.ForEach(i => Console.WriteLine("Course ID: " + "{0}\t", i));
            Console.WriteLine(GetType());
            Console.WriteLine();
        }

    }
}
