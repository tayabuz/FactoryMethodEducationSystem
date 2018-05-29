using System;
using System.Collections.Generic;

namespace FactoryMethodEducationSystem.Base_Classes
{
    public abstract class TeacherBase
    {
        private const string PREFIX = "01";
        private static int NumberOfCreatedObject = 0;
        public string ID { get; }
        public int Experience { get; set; }
        public string Name { get; set; }
        public List<string> Courses = new List<string>();

        protected TeacherBase(string name, int exp, string[] courses)
        {
            Name = name;
            Courses.AddRange(courses);
            Experience = exp;
            ID = PREFIX + NumberOfCreatedObject;
            NumberOfCreatedObject++;
        }
        public void PrintInfoAbout()
        {
            Console.WriteLine("Teacher ID: " + ID);
            Console.WriteLine("Teacher Name: " + Name);
            Courses.ForEach(i => Console.WriteLine("Course ID: " + "{0}\t", i));
            Console.WriteLine(GetType());
            Console.WriteLine();
        }
    }
}
