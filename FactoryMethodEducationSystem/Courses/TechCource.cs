using FactoryMethodEducationSystem.Base_Classes;

namespace FactoryMethodEducationSystem.Courses
{
    class TechCource:CourseBase
    {
        public TechCource(string name, string[] teachers, string[] students) : base(name, teachers, students)
        {
            PrintInfoAbout();
        }
    }
}
